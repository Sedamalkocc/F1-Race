namespace F1_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciarabasolauzaklık, ikinciarabasolauzaklık, üçüncüarabasolauzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            int birinciarabagenişliği = pictureBox1.Width;
            int ikinciarabagenişliği = pictureBox2.Width;
            int üçüncüarabagenişliği = pictureBox3.Width;

            int bitişuzaklığı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + random.Next(6, 15);
            pictureBox2.Left = pictureBox2.Left + random.Next(6, 15);
            pictureBox3.Left = pictureBox3.Left + random.Next(6, 15);

            if(pictureBox1.Left > pictureBox2.Left +6 && pictureBox1.Left > pictureBox3.Left +6)
            {
                label9.Text = "Mercedes Yarışı Önde Götürüyor.  MERCEDES ÖNDEEE";
            }
            

            if(pictureBox2.Left > pictureBox3.Left +6 && pictureBox2.Left > pictureBox1.Left +6)
            {

                label9.Text = "Ferrari İyi Bir Atakla Öne Geçiyor.  FERRARİ ÖNDEEE";
            }
            
            
            if(pictureBox3.Left > pictureBox2.Left +6 && pictureBox3.Left > pictureBox1.Left +6)
            {
                label9.Text = "Red Bull Liderliği Ele Geçiriyor.  RED BULL ÖNDEEE";
            }
            

            if(birinciarabagenişliği+pictureBox1.Left >= bitişuzaklığı)
            {
                timer1.Enabled=false;
                label9.Text ="Mercedes AMG Kazandı!!! Lewis HAMİLTON Kazandı!!!";
            }
            
            if(ikinciarabagenişliği + pictureBox2.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;
                label9.Text ="Scuderia Ferrari Kazandı!!! Charles LECLERC Kazandı!!!";
            }

            if(üçüncüarabagenişliği + pictureBox3.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;
               label9.Text ="Red Bull Kazandı!!! Max VERSTAPPEN Kazandı!!!";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            label9.Text = "";
            
            pictureBox1.Left = birinciarabasolauzaklık;
            pictureBox2.Left = ikinciarabasolauzaklık;
            pictureBox3.Left = üçüncüarabasolauzaklık;
        }

       

        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciarabasolauzaklık = pictureBox1.Left;
            ikinciarabasolauzaklık = pictureBox2.Left;
            üçüncüarabasolauzaklık = pictureBox3.Left;

        }
    }
}