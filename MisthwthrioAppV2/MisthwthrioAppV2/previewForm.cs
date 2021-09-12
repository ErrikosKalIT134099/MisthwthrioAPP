using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisthwthrioAppV2
{
    public partial class previewForm : Form
    {
        string ekmisthwths,mOnoma,mEponymo,mToposKatoikias,mADT;
        string mAfm,adress,city,floor,useM,datepick;
        double tetMetra;
        int misthwma,guaranty;
        public previewForm(string ekmisthwth,string onoma, string eponymo, string toposkatoikias, string adt,string afm,string dieuf,string polh,string orof,int misth,int egguhsh,string xrhsh,double tm,string date)
        {
            InitializeComponent();
            ekmisthwths=ekmisthwth;
            mOnoma = onoma;
            mEponymo = eponymo;
            mToposKatoikias = toposkatoikias;
            mADT = adt;
            mAfm = afm;
            adress = dieuf;
            city = polh;
            floor = orof;
            misthwma = misth;
            guaranty = egguhsh;
            useM = xrhsh;
            tetMetra = tm;
            datepick = date;
        }

        private void priviewForm_Load(object sender, EventArgs e)
        {
            
            AdvRichTextBox aRTB = new AdvRichTextBox();


            aRTB.SelectionAlignment = TextAlign.Center;
            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Bold | FontStyle.Underline);
            aRTB.SelectedText = "ΜΙΣΘΩΤΗΡΙΟ ΣΥΜΦΩΝΗΤΙΚΟ ΚΑΤΟΙΚΙΑΣ\n\n";

            aRTB.SelectionAlignment = TextAlign.CenterJustify;

            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Regular);
            aRTB.AppendText("Σήμερα την ..."+datepick+"... στην πόλη Κομοτηνή οι υπογράφοντες το συμφωνητικό  αυτό αφενός "+ekmisthwths+" και αφετέρου ..." +
                           mOnoma+" "+mEponymo+"... κάτοικος "+ mToposKatoikias + " Α.Φ.Μ ..."+ mAfm + "... κάτοχος του υπ’αριθ. ..."+ mADT + "... δελτίου ταυτότητας που εκδόθηκε την ………………. από το ………………… " +
                          "αποκαλούμενος στο εξής “μισθωτής”,συμφώνησαν από κοινού και αποδέχτηκαν τα εξής:\n\n");

            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Bold);
            aRTB.AppendText("1. ΜΙΣΘΙΟ");
            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Regular);

            aRTB.AppendText(" Ο πρώτος συμβαλλόμενος “εκμισθωτής” εκμισθώνει με το συμφωνητικο αυτό στον δεύτερο συμβαλλόμενο “μισθωτή” ένα διαμέρισμα(κατοικία) και ειδικοτερα" +
                              "στον ..."+floor+"... όροφο που βρίσκεται στην πόλη ..."+city+"... στην οδό ..."+adress+"..."+tetMetra+"....τ.μ\n\n");

            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Bold);
            aRTB.AppendText("2. ΜΙΣΘΩΜΑ");
            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Regular);
            aRTB.AppendText("Το μίσθωμα ορίζεται σε ..."+misthwma+"... €. Το μίσθωμα  συμφωνείται να καταβάλλεται μέσα στο πρώτο τριήμερο κάθε μήνα στην κατοικία του “εκμισθωτή” που αναφέρεται παραπάνω " +
            "ή σε τραπεζικό λογαριασμό που τυχόν θα υποδειχθεί εγγράφως από τον “εκμισθωτη” . Η καταβολή του μισθώματος αποδεικνύεται μόνο με την έγγραφη απόδειξη  του “εκμισθωτή” ή " +
            "εξουσιοδοτημένου απ’αυτόν πρόσωπο ή της τράπεζας αποκλειόμενου κάθε άλλου αποδεικτικού μέσου. Οι συμβαλλόμενοι θεωρούν το μίσθωμα δίκαιο και ανάλογο με την μισθωτική αξία " +
            "του ακινήτου και παραιτούνται από κάθε δικαίωμα αμφισβήτησης του.\n\n");


            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Bold);
            aRTB.AppendText("3. ΔΙΑΡΚΕΙΑ");
            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Regular);
            aRTB.AppendText(" Η διάρκεια της παρούσας μίσθωσης ορίζεται …………………… Αρχιζει την ………………… ληγει την ………………………..\n\n");

            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Bold);
            aRTB.AppendText("4. ΕΓΓΥΗΣΗ");
            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Regular);
            aRTB.AppendText(" Για την ακριβή εκπλήρωση των όρων της μίσθωσης , ο “μισθωτής” κατέβαλε σήμερα στον “εκμισθωτή” το ποσό των ..."+guaranty+"€... . Το ποσό αυτό που θα αναπροσαρμόζεται σε κάθε " +
                "αύξηση του μισθώματος κατα το ίδιο ποσοστό,θα του επιστραφεί μετά την εμπρόθεσμη κατα τη λήξη της μίσθωσης,αποχώρηση του από το μίσθιο, την παράδοση του μισθίου και των" +
                " κλειδιών του, καθώς και την εκκαθάριση όλων των τυχόν εκκρεμών λογαριασμών.Συμφωνείται ρητά ότι η εγγύηση αυτή δεν μπορεί σε καμία περίπτωση να συμψηφιστεί με τα μισθώματα" +
                " η αλλες οφειλές του μισθωτή προς τον “εκμισθωτή”\n\n");

            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Bold);
            aRTB.AppendText("5. ΧΡΗΣΗ ");
            aRTB.SelectionFont = new Font("Georgia", 11, FontStyle.Regular);
            aRTB.AppendText("Το μίσθιο θα χρησιμοποιηθεί ως κατοικία ..."+useM+"... καθώς και των εξής μελών της οικογενείας του ……………………………………………………………………………………… Απαγορεύεται απόλυτα οποιαδήποτε" +
                " μετατροπή της χρήσης του μισθίου καθώς και η ολική ή μερική υπομίσθωση του ή με οποιοδήποτε τρόπο με ή χωρίς αντάλλαγμα παραχώρηση της χρήσης, του μισθίου σε τρίτους ή συγκατοίκηση" +
                " ή φιλοξενία άλλων προσώπων χωρίς την έγγραφη συναίνεση του εκμισθωτή.\n\n");



            aRTB.SaveFile("D:/awd2.rtf");

            aRTB.Width = 700;
            aRTB.Height = 842;
            this.Controls.Add(aRTB);
        }
    }
}
