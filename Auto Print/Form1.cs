using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Renci.SshNet;
using System.IO;
using System.Printing;
using System.Drawing.Printing;

namespace Auto_Print
{
    public partial class Form1 : Form
    {
        int i;
        List<string> ftp_list = new List<string>();
        Image img, img1;
        List<string> family_images = new List<string>();
        List<string> adult_images = new List<string>();
        List<string> child_images = new List<string>();
        int intPicCount, intPrintCount;
        List<string> imageName_list = new List<string>();
        List<string> imageAddress_list = new List<string>();
        List<string> lstRef = new List<string>();   
        List<string> imageFTP_list = new List<string>();
        string strPhoto,strToPrint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {
            cmdCancelPrinting.Visible = false;
            lblPhotosLeft.Text = "";
            lblPicCount.Text = "";
            lblInfo.Text = "";
            cboPrinter.Items.Clear();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboPrinter.Items.Add(printer);
            }
            cboPrinter.Text = Properties.Settings.Default.apPreferPrinter.ToString();
            timer1.Interval = Properties.Settings.Default.apWait*1000;
            timer1.Stop();
            pnlSettings.Left = 165;
            pnlSettings.Top = 53;
            pnlPrint.Top = 53;
            pnlPrint.Left = 165;
            pnlSettings.Visible = false;
            loadFTP();
            loadPhotoNames();
            txtPicSize.Text = Properties.Settings.Default.apPhotoSize.ToString();
            txtWaitInterval.Text = Properties.Settings.Default.apWait.ToString();
            txtLocalSave.Text = Properties.Settings.Default.apSaveLocal.ToString();
            cboPaperSize.Text = Properties.Settings.Default.apPaperSize.ToString();
            resizeToFit();
            cmdPrint.Enabled = false;
            loadPaperSizes();
            i = 0;
            while (i<cboPaperSize.Items.Count)
            {
                if (cboPaperSize.Items[i].ToString() == Properties.Settings.Default.apPaperSize.ToString())
                {
                    cboPaperSize.SelectedIndex = i;
                    i = cboPaperSize.Items.Count;
                }
                i = i + 1;
            }
        }

        private void loadFTP()
        {
            txtFTPAdult.Text = Properties.Settings.Default.apRFAdult.ToString();
            txtFTPChild.Text = Properties.Settings.Default.apRFChild.ToString();
            txtFTPFamily.Text = Properties.Settings.Default.apRFFamily.ToString();
            txtFTPRF.Text = Properties.Settings.Default.apRF.ToString();

            txtFTPHost.Text = Properties.Settings.Default.apHost.ToString();
            txtFTPPort.Text = Properties.Settings.Default.apPort.ToString();
            txtFTPPasssword.Text = Properties.Settings.Default.apPassword.ToString();
            txtFTPUsername.Text = Properties.Settings.Default.apUsername.ToString();
        }

        private void loadPhotoNames()
        {
            cboPicture.Items.Clear();
            lstNames.Items.Clear();
            lstdescription.Items.Clear();
            string[] strSplit = Properties.Settings.Default.apNames.ToString().Split(',');
            for (i = 0; i < strSplit.Count(); i++)
            {
                lstNames.Items.Add(strSplit[i].ToString());
            }
            strSplit = Properties.Settings.Default.apDescription.ToString().Split(',');
            for (i = 0; i < strSplit.Count(); i++)
            {
                lstdescription.Items.Add(strSplit[i].ToString());
                cboPicture.Items.Add(strSplit[i].ToString());
            }
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            if (cboPicture.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the picture you want to print", "Choose your Picture", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (CheckForIllegalCrossThreadCalls == true)
                {
                    lstRef.Clear();
                    strPhoto = lstNames.Items[cboPicture.SelectedIndex].ToString();
                    pnlPrint.Controls.Clear();
                    lblInfo.Text = "Sending request";
                    lblInfo.Refresh();
                    string theDate = dtp1.Value.ToShortDateString();
                    String urlstr = "https://4k-photos.co.uk/gatherDataNewAll.php?date=" + theDate.ToString();
                    WebClient client = new WebClient();
                    System.IO.Stream response = client.OpenRead(urlstr);
                    System.IO.StreamReader reads = new System.IO.StreamReader(response);
                    cmdFind.Enabled = false;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Internet is currently unavailable, please check internet connection and try again", "Internet error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void cmdToPrint_Click(object sender, EventArgs e)
        {
            pnlPrint.Visible = true;
            pnlSettings.Visible = false;
            pnlPicFinder.Visible = true;
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            pnlPrint.Visible = false;
            pnlPicFinder.Visible = false;
            pnlSettings.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "Downloading file";
            lblInfo.Refresh();
            timer1.Enabled = false;
            readFile();
            loadPictures();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void readFile()
        {
            //read the file created by the php function after a certain amount of time

            //variables
            string c, b;
            string strread;

            //attempt to download information from server
            string Host = Properties.Settings.Default.apHost.ToString();
            int Port = Properties.Settings.Default.apPort;
            string Username = Properties.Settings.Default.apUsername.ToString();
            string Password = Properties.Settings.Default.apPassword.ToString();

            try
            {
                ftp_list.Clear();
                using (var sftp = new SftpClient(Host, Port, Username, Password))
                {
                    sftp.Connect(); //connect to server

                    c = dtp1.Value.ToShortDateString().ToString().Replace(@"/", "") + "gathered.txt";
                    b = Properties.Settings.Default.apSaveLocal.ToString() + "/" + c;
                    c = Properties.Settings.Default.apRF.ToString() + "/" + c;
                    using (var file = File.OpenWrite(b))
                    {
                        sftp.DownloadFile(c, file);//download file
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to connect to ftp site, checking backups");
            }

            //read file
            lblInfo.Text = "Reading file";
            lblInfo.Refresh();
            try
            {
                var list = new List<string>();
                strread = Properties.Settings.Default.apSaveLocal.ToString() + "\\" + dtp1.Value.ToShortDateString().ToString().Replace(@"/", "")+ "gathered.txt";
                var fileStream = new FileStream(strread, FileMode.Open, System.IO.FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                fileStream.Close();

                i = 0;
                while (i < list.Count())
                {
                    List<string> questionsSplit = list[i].ToString().Split(',').ToList<string>();
                    lstRef.Add(questionsSplit[0].ToString());
                    i = i + 1;
                }
            }
            catch
            {
                MessageBox.Show("Problem reading downloaded text file", "File Error");
            }

        }

        private void clearGroupBoxes()
        {
            //gbPhotos.Controls.Clear();
            pnlPrint.Controls.Clear();
        }

        private void loadPictures()
        {
            //variables
            lblInfo.Text = "Sorting Pictures";
            lblInfo.Refresh();
            string Host = Properties.Settings.Default.apHost;
            int Port = Properties.Settings.Default.apPort;
            string Username = Properties.Settings.Default.apUsername;
            string Password = Properties.Settings.Default.apPassword;

            string c, b, ga, gc, gf;

            string strRemoteFolderC = Properties.Settings.Default.apRFChild.ToString();
            List<string> child_list = new List<string>();

            string strRemoteFolderA = Properties.Settings.Default.apRFAdult.ToString();
            List<string> adult_list = new List<string>();

            string strRemoteFolderF = Properties.Settings.Default.apRFFamily.ToString();
            List<string> family_list = new List<string>();


            gf = Properties.Settings.Default.apSaveLocal + "\\Family Photos";
            ga = Properties.Settings.Default.apSaveLocal + "\\Adult Photos";
            gc = Properties.Settings.Default.apSaveLocal + "\\child Photos";

            imageName_list.Clear();
            imageAddress_list.Clear();
            imageFTP_list.Clear();
            adult_images.Clear();
            child_images.Clear();
            family_images.Clear();

            int x = 0;

            //clear group boxes
            clearGroupBoxes();

            //connect to server
            ftp_list.Clear();
            using (var sftp = new SftpClient(Host, Port, Username, Password))
            {
                sftp.Connect(); //connect to server

                //add every file in each directory to a list
                child_list = sftp.ListDirectory(Properties.Settings.Default.apRFChild).Where(f => !f.IsDirectory).Select(f => f.Name).ToList();
                adult_list = sftp.ListDirectory(Properties.Settings.Default.apRFAdult).Where(f => !f.IsDirectory).Select(f => f.Name).ToList();
                family_list = sftp.ListDirectory(Properties.Settings.Default.apRFFamily).Where(f => !f.IsDirectory).Select(f => f.Name).ToList();

                //create a adult folder if it doesnt exist and delete all files inside it
                System.IO.Directory.CreateDirectory(ga);
                DirectoryInfo dir = new DirectoryInfo(ga);
                foreach (FileInfo fi in dir.GetFiles())
                {
                    try
                    {
                        fi.Delete();
                   }
                    catch
                   { }
                }

                //create a child folder if it doesnt exist and delete all files inside it

                System.IO.Directory.CreateDirectory(gc);
                dir = new DirectoryInfo(gc);
                foreach (FileInfo fi in dir.GetFiles())
                {
                    try
                    {
                        fi.Delete();
                    }
                    catch
                    { }
                }

                //create a family folder if it doesnt exist and delete all files inside it
                System.IO.Directory.CreateDirectory(gf);
                dir = new DirectoryInfo(gf);
                foreach (FileInfo fi in dir.GetFiles())
                {
                    try
                    {
                        fi.Delete();
                    }
                    catch
                    { }
                }

                //cycle through all references
                while (x < lstRef.Count)
                {
                    //find pictures in adult folder
                    i = 0;
                    while (i < adult_list.Count)
                    {
                        //cycle through the list and if it contains the reference number then down the picture
                        if (adult_list[i].ToString().Contains(lstRef[x].ToString()) && adult_list[i].ToString().Contains(".jpg") && adult_list[i].ToString().Contains(strPhoto))
                        {
                            adult_images.Add(adult_list[i]);
                            imageName_list.Add(adult_list[i]);
                            imageAddress_list.Add(ga + "\\" + adult_list[i]);
                            imageFTP_list.Add(Properties.Settings.Default.apRFAdult + "/" + adult_list[i]);
                            c = Properties.Settings.Default.apRFAdult + "/" + adult_list[i]; //update download file from sftp
                            b = ga + "\\" + adult_list[i];//update download folder to pc 
                            try
                            {
                                using (var file = File.OpenWrite(b))
                                {
                                    sftp.DownloadFile(c, file);//download file
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Problem downloading adult pictures");
                            }
                        }
                        i = i + 1;
                    }

                    //find pictures in child folder
                    i = 0;
                    while (i < child_list.Count)
                    {
                        //cycle through the list and if it contains the reference number then down the picture
                        if (child_list[i].ToString().Contains(lstRef[x].ToString()) && child_list[i].ToString().Contains(".jpg") && child_list[i].ToString().Contains(strPhoto))
                        {
                            child_images.Add(child_list[i]);
                            imageName_list.Add(child_list[i]);
                            imageAddress_list.Add(gc + "\\" + child_list[i]);
                            imageFTP_list.Add(Properties.Settings.Default.apRFChild + "/" + child_list[i]);
                            c = Properties.Settings.Default.apRFChild + "/" + child_list[i]; //update download file from sftp
                            b = gc + "\\" + child_list[i];//update download folder to pc 
                           try
                            {
                                using (var file = File.OpenWrite(b))
                                {
                                    sftp.DownloadFile(c, file);//download file
                                }
                            }
                            catch
                            { }
                        }
                        i = i + 1;
                    }


                    //find pictures in family folder
                    i = 0;
                    while (i < family_list.Count)
                    {
                        //cycle through the list and if it contains the reference number then down the picture
                        if (family_list[i].ToString().Contains(lstRef[x].ToString()) && family_list[i].ToString().Contains(".jpg") && family_list[i].ToString().Contains(strPhoto))
                        {
                            family_images.Add(family_list[i]);
                            imageName_list.Add(family_list[i]);
                            imageAddress_list.Add(gf + "\\" + family_list[i]);
                            imageFTP_list.Add(Properties.Settings.Default.apRFFamily + "/" + family_list[i]);
                            c = Properties.Settings.Default.apRFFamily + "/" + family_list[i]; //update download file from sftp
                            b = gf + "\\" + family_list[i];//update download folder to pc 
                            try
                            {
                                using (var file = File.OpenWrite(b))
                                {
                                    sftp.DownloadFile(c, file);//download file
                                }
                            }
                            catch
                            { }
                        }
                        i = i + 1;
                    }
                    x = x + 1;
                }
            }

            //display pictures
            displayPictures();
        }

        private void cmdDeletePhoto_Click(object sender, EventArgs e)
        {
            int intDel = lstdescription.SelectedIndex;
            lstdescription.Items.RemoveAt(intDel);
            lstNames.Items.RemoveAt(intDel);
            cboPicture.Items.RemoveAt(intDel);
            updatePhotoSaves();
            loadPhotoNames();
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = lstNames.SelectedIndex;
            updateListIndex();
        }

        private void updateListIndex()
        {
            lstNames.SelectedIndex = i;
            lstdescription.SelectedIndex = i;
        }

        private void lstdescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = lstdescription.SelectedIndex;
            updateListIndex();
        }

        private void cmdSaveNewPhoto_Click(object sender, EventArgs e)
        {
            addPhoto();
        }

        private void addPhoto()
        {
            if (txtAddDescription.Text == "" || txtAddPhoto.Text == "")
            {
                MessageBox.Show("Please add both the description and name to add to selection", "Missing details", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                lstdescription.Items.Add(txtAddDescription.Text);
                lstNames.Items.Add(txtAddPhoto.Text);
                cboPicture.Items.Add(txtAddPhoto.Text);
                txtAddPhoto.Text = "";
                txtAddDescription.Text = "";
                updatePhotoSaves();
            }
        }

        private void updatePhotoSaves()
        {
            if (lstNames.Items.Count >-1)
            {
                List<string> listNames = new List<string>();
                List<string> listDesc = new List<string>();
                string p="", q = "";

                for (i=0; i<lstNames.Items.Count; i++)
                {
                    listNames.Add(lstNames.Items[i].ToString());
                    listDesc.Add(lstdescription.Items[i].ToString());
                }

                i = 0;
                while (i<listNames.Count-1)
                {
                    if (string.Compare(listDesc[i],listDesc[i+1])<0)
                    {
                        i = i + 1;
                    }
                    else
                    //if (string.Compare(listDesc[i], listDesc[i+1])>0)
                    {
                        p=listDesc[i];
                        q = listNames[i];
                        listDesc[i] = listDesc[i + 1];
                        listNames[i] = listNames[i + 1];
                        listDesc[i + 1] = p;
                        listNames[i + 1] = q;
                        i = 0;
                    }
                }
                lstNames.Items.Clear();
                lstdescription.Items.Clear();
                cboPicture.Items.Clear();
                for (i=0;i<listNames.Count;i++)
                {
                    lstNames.Items.Add(listNames[i].ToString());
                    lstdescription.Items.Add(listDesc[i].ToString());
                    cboPicture.Items.Add(listDesc[i].ToString());
                }
            }

            if (lstNames.Items.Count > -1)
            {
                string strTemp = lstNames.Items[0].ToString();
                for (i = 1; i < lstNames.Items.Count; i++)
                {
                    strTemp = strTemp + "," + lstNames.Items[i].ToString();
                }
                Properties.Settings.Default.apNames = strTemp;

                strTemp = lstdescription.Items[0].ToString();
                for (i = 1; i < lstdescription.Items.Count; i++)
                {
                    strTemp = strTemp + "," + lstdescription.Items[i].ToString();
                }
                Properties.Settings.Default.apDescription = strTemp;
            }
            else
            {
                Properties.Settings.Default.apDescription = "";
                Properties.Settings.Default.apNames = "";
            }

            Properties.Settings.Default.Save();
            
        }

        private void cmdCancelFTP_Click(object sender, EventArgs e)
        {
            loadFTP();
        }

        private void cmdSaveFTP_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.apRFChild = txtFTPChild.Text;
            Properties.Settings.Default.apRFAdult = txtFTPAdult.Text;
            Properties.Settings.Default.apRFFamily = txtFTPFamily.Text;
            Properties.Settings.Default.apRF = txtFTPRF.Text;

            Properties.Settings.Default.apHost = txtFTPHost.Text;
            Properties.Settings.Default.apUsername = txtFTPUsername.Text;
            Properties.Settings.Default.apPassword = txtFTPPasssword.Text;
            Properties.Settings.Default.apPort = Int32.Parse(txtFTPPort.Text);

            Properties.Settings.Default.Save();
        }

        private void cmdSaveInterval_Click(object sender, EventArgs e)
        {
            saveInterval();
        }

        private void saveInterval()
        {
            try
            {
                Properties.Settings.Default.apWait = Int32.Parse(txtWaitInterval.Text);
                Properties.Settings.Default.Save();
                timer1.Interval = Properties.Settings.Default.apWait;
            }
            catch
            {
                MessageBox.Show("Timer not updated, please ensure its a valid number", "Wait error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdPicSize_Click(object sender, EventArgs e)
        {
            savePicSize();
        }

        private void savePicSize()
        {
            try
            {
                Properties.Settings.Default.apPhotoSize = Int32.Parse(txtPicSize.Text);
                Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Picture size not updated. Please ensure its a valid number", "Size error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdBrowseLocalSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLocalSave.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.apSaveLocal = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeToFit();
        }

        private void resizeToFit()
        {
            pnlPicFinder.Left = (pnlTop.Width / 2) - (pnlPicFinder.Width / 2);
            pnlPrinter.Left = (pnlBottom.Width / 2) - (pnlPrinter.Width / 2);
            cmdSettings.Top = this.Height - 100;
            cmdToPrint.Top = this.Height - 150;
            pnlSettings.Height = this.Height - pnlTop.Height;
            pnlSettings.Width = this.Width - pnlLeft.Width;
            pnlPrint.Width = this.Width - pnlLeft.Width;
            pnlPrint.Height = this.Height - pnlTop.Height - pnlBottom.Height;
        }

        private void cboPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.apPreferPrinter = cboPrinter.Items[cboPrinter.SelectedIndex].ToString();
            Properties.Settings.Default.Save();
            cboPaperSize.SelectedIndex = -1;
            cboPaperSize.Items.Clear();
            loadPaperSizes();
        }

        private void loadPaperSizes()
        {
            if (cboPrinter.SelectedIndex > -1)
            {
                cboPaperSize.Items.Clear();
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings.PrinterName = cboPrinter.Text;
                PaperSize pkSize;
                for (int i = 0; i < printDoc.PrinterSettings.PaperSizes.Count; i++)
                {
                    pkSize = printDoc.PrinterSettings.PaperSizes[i];
                    cboPaperSize.Items.Add(pkSize);
                }
            }
        }
        private void txtAddPhoto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddDescription.Focus();
            }
        }

        private void txtAddDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addPhoto();
            }
        }

        private void txtAddDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWaitInterval_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveInterval();
            }
        }

        private void txtPicSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                savePicSize();
            }
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (cboPrinter.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a printer before printing", "No Printer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (pnlPrint.Controls.Count ==0)
                {
                    MessageBox.Show("There are no photos to print!","No Photos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    printAllPictures();
                }
            }
        }

        private void printAllPictures()
        {
            intPrintCount = pnlPrint.Controls.Count;
            lblPhotosLeft.Text = intPrintCount.ToString();

            string gf = Properties.Settings.Default.apSaveLocal + "\\Family Photos";
            string ga = Properties.Settings.Default.apSaveLocal + "\\Adult Photos";
            string gc = Properties.Settings.Default.apSaveLocal + "\\child Photos";

            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = cboPrinter.Text;
            PaperSize pk = pd.PrinterSettings.PaperSizes[cboPaperSize.SelectedIndex];
            pd.DefaultPageSettings.PaperSize = pk;
            pd.DefaultPageSettings.Landscape = true;

            string[] filesc = Directory.GetFiles(gc);
            foreach (string file in filesc)
            {
                strToPrint = file.ToString();
                //pd.PrintPage += PrintPage;
                pd.PrintPage += (sender, args) =>
                {
                    Image i = Image.FromFile(@strToPrint);
                    Rectangle m = args.MarginBounds;

                    if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
                    {
                        m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
                    }
                    else
                    {
                        m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
                    }
                    args.Graphics.DrawImage(i, m);
                };
                pd.Print();
            }

            string[] filesa = Directory.GetFiles(ga);
            foreach (string file in filesa)
            {
                strToPrint = file.ToString();
                //pd.PrintPage += PrintPage;
                pd.PrintPage += (sender, args) =>
                {
                    Image i = Image.FromFile(@strToPrint);
                    Rectangle m = args.MarginBounds;

                    if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
                    {
                        m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
                    }
                    else
                    {
                        m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
                    }
                    args.Graphics.DrawImage(i, m);
                };
                pd.Print();
            }

            string[] filesf = Directory.GetFiles(gf);
            foreach (string file in filesf)
            {
                strToPrint = file.ToString();
                //pd.PrintPage += PrintPage;
                pd.PrintPage += (sender, args) =>
                {
                    Image i = Image.FromFile(@strToPrint);
                    Rectangle m = args.MarginBounds;

                    if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
                    {
                        m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
                    }
                    else
                    {
                        m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
                    }
                    args.Graphics.DrawImage(i, m);
                };
                pd.Print();
            }

            lblInfo.Text = "Printing";
            lblInfo.Refresh();
            dtp1.Enabled = false;
            cboPicture.Enabled = false;
            cmdFind.Enabled = false;
            cboPrinter.Enabled = false;
            cboPaperSize.Enabled = false;
            cmdPrint.Enabled = false;
            cmdCancelPrinting.Visible = true;
            timer2.Start();
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@strToPrint);
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LocalPrintServer ps = new LocalPrintServer();
            PrintQueue pq = ps.GetPrintQueue(Properties.Settings.Default.apPreferPrinter);
            int intJobs = pq.NumberOfJobs;
            lblPhotosLeft.Text = intJobs.ToString();
            lblPhotosLeft.Refresh();
            if (intJobs == 0)
            {
                timer2.Stop();
                lblInfo.Text = "Finished Printing";
                lblInfo.Refresh();
                dtp1.Enabled = true;
                cboPicture.Enabled = true;
                cmdFind.Enabled = true;
                cboPrinter.Enabled = true;
                cboPaperSize.Enabled = true;
                cmdPrint.Enabled = true;
                cmdCancelPrinting.Visible = false;
            }
        }

        private void cmdCancelPrinting_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to cancel the remaining prints?", "Cancel print job?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                using (LocalPrintServer ps2 = new LocalPrintServer())
                {
                    using (PrintQueue pq2 = new PrintQueue(ps2,Properties.Settings.Default.apPreferPrinter,PrintSystemDesiredAccess.AdministratePrinter))
                    {
                        pq2.Purge();
                    }
                }
                dtp1.Enabled = true;
                cboPicture.Enabled = true;
                cmdFind.Enabled = true;
                cboPrinter.Enabled = true;
                cboPaperSize.Enabled = true;
                cmdPrint.Enabled = true;
                cmdCancelPrinting.Visible = false;
            }
        }

        private void cboPaperSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.apPaperSize = cboPaperSize.Text;
            Properties.Settings.Default.Save();
        }

     

        private void NewButton_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            // Button btn = (Button)sender;

            for (int i = 0; i < intPicCount; i++)
            {
                if (btn.Name == ("pic" + i))
                {
                }
            }
        }

        private void displayPictures()
        {
            lblInfo.Text = "Displaying pictures";
            lblInfo.Refresh();
            int picSize = Properties.Settings.Default.apPhotoSize;
            intPicCount = 0;

            int intx = 16;
            int inty = 25;

            string gf = Properties.Settings.Default.apSaveLocal + "/Family Photos";
            string ga = Properties.Settings.Default.apSaveLocal + "/Adult Photos";
            string gc = Properties.Settings.Default.apSaveLocal + "/child Photos";
            //Dynamically create pictureboxes and load adult pictures
            i = 0;
            while (i < adult_images.Count)
            {
                PictureBox pba = new PictureBox();
                pba.Name = "pic" + intPicCount.ToString();
                pba.Click += new EventHandler(NewButton_Click);
                pba.Location = new System.Drawing.Point(intx, inty);
                pba.Size = new System.Drawing.Size(picSize, picSize);

                using (FileStream stream = new FileStream(ga + "//" + adult_images[i], FileMode.Open, FileAccess.Read))
                {
                    img1 = Image.FromStream(stream);
                }
                pba.BackgroundImage = img1;
                pba.BackgroundImageLayout = ImageLayout.Stretch;
                pnlPrint.Controls.Add(pba);

                i = i + 1;
                intx = intx + picSize + 10;
                if (intx + 10 + picSize > pnlPrint.Width)
                {
                    intx = 16;
                    inty = inty + picSize + 10;
                }
                intPicCount = intPicCount + 1;
            }

            //Dynamically create pictureboxes and load child pictures
            i = 0;
            while (i < child_images.Count)
            {
                PictureBox pbc = new PictureBox();
                pbc.Name = "pic" + intPicCount.ToString();
                pbc.Click += new EventHandler(NewButton_Click);
                pbc.Location = new System.Drawing.Point(intx, inty);
                pbc.Size = new System.Drawing.Size(picSize, picSize);

                using (FileStream stream = new FileStream(gc + "//" + child_images[i], FileMode.Open, FileAccess.Read))
                {
                    img1 = Image.FromStream(stream);
                }
                pbc.BackgroundImage = img1;
                pbc.BackgroundImageLayout = ImageLayout.Stretch;
                pnlPrint.Controls.Add(pbc);

                i = i + 1;
                intx = intx + picSize + 10;
                if (intx + 10 + picSize > pnlPrint.Width)
                {
                    intx = 16;
                    inty = inty + picSize + 10;
                }
                intPicCount = intPicCount + 1;
            }

            //Dynamically create pictureboxes and load family pictures
            i = 0;
            while (i < family_images.Count)
            {
                PictureBox pbf = new PictureBox();
                pbf.Name = "pic" + intPicCount.ToString();
                pbf.Click += new EventHandler(NewButton_Click);
                pbf.Location = new System.Drawing.Point(intx, inty);
                pbf.Size = new System.Drawing.Size(picSize, picSize);

                using (FileStream stream = new FileStream(gf + "//" + family_images[i], FileMode.Open, FileAccess.Read))
                {
                    img1 = Image.FromStream(stream);
                }
                pbf.BackgroundImage = img1;
                pbf.BackgroundImageLayout = ImageLayout.Stretch;
                pnlPrint.Controls.Add(pbf);

                i = i + 1;
                intx = intx + picSize + 10;
                if (intx + 10 + picSize > pnlPrint.Width)
                {
                    intx = 16;
                    inty = inty + 10 + picSize;
                }
                intPicCount = intPicCount + 1;
            }
            pnlPrint.Visible = true;
            lblInfo.Text = "Finished";
            cmdFind.Enabled = true;
            cmdPrint.Enabled = true;
            lblPicCount.Text = pnlPrint.Controls.Count.ToString();
        }
    }
}
