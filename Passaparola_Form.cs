using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Passaparola_Form : Form
    {

        int questionNumber = 0;
        int correctAnswer = 0;
        int wrongAnswer = 0;

        public Passaparola_Form()
        {
            InitializeComponent();
        }

        private void StartPassaparola_Button_Click(object sender, EventArgs e)
        {
            if (StartPassaparola_Button.Text == "Start Passaparola")
            {
                StartPassaparola_Button.Text = "Show Other Question";
            }

            questionNumber++;

            CorrectAnswers_Button.Text = $"Correct Answers -> {correctAnswer}";
            WrongAnswers_Button.Text = $"Wrong Answers -> {wrongAnswer}";

            switch (questionNumber)
            {
                case 1:
                    Question_RichTextBox.Text = "A state which is located in United States and the capital city is Little Rock?"; // Arkansas
                    break;
                case 2:
                    Question_RichTextBox.Text = "Which country has got the country code +55?"; // Brazil
                    break;
                case 3:
                    Question_RichTextBox.Text = "A car brand which is founded by Henry Martyn Leland"; // Cadillac
                    break;
                case 4:
                    Question_RichTextBox.Text = "The science of human skin, also a medical area."; // Dermatology
                    break;
                case 5:
                    Question_RichTextBox.Text = "An american jazz vocalist who has hold 13 grammies."; // Ella Fitzgerald
                    break;
                case 6:
                    Question_RichTextBox.Text = "The fifth day of a week."; // Friday
                    break;
                case 7:
                    Question_RichTextBox.Text = "The scientist who founded phone."; // Graham Bell
                    break;
                case 8:
                    Question_RichTextBox.Text = "A sexual orientation who only sexually likes their same gender."; // Homosexuality
                    break;
                case 9:
                    Question_RichTextBox.Text = "A city in Turkey named Constantinopolis before."; // İstanbul
                    break;
                case 10:
                    Question_RichTextBox.Text = "A state which is located in United States and the capital city is Springfield?"; // Illinois
                    break;
                case 11:
                    Question_RichTextBox.Text = "The founder of Amazon"; // Jeff Bezos
                    break;
                case 12:
                    Question_RichTextBox.Text = "The last helenistic queen of Egypt"; // Kleopatra
                    break;
                case 13:
                    Question_RichTextBox.Text = "The founder of Linux operating system and the developer of the kernel."; // Linus Torvalds
                    break;
                case 14:
                    Question_RichTextBox.Text = "One of the biggest corporations founded by Bill Gates."; // Microsoft
                    break;
                case 15:
                    Question_RichTextBox.Text = "A country located in West Africa. The flag is green-white-green."; // Nigeria
                    break;
                case 16:
                    Question_RichTextBox.Text = "A state which is located in United States and the capital city is Salem?"; // Oregon
                    break;
                case 17:
                    Question_RichTextBox.Text = "A state which is located in United States and the capital city is Harrisburg?"; // Pennsylvania
                    break;
                case 18:
                    Question_RichTextBox.Text = "A database system invented by Salvatore Sanfilippo"; // Redis
                    break;

                case 19:
                    Question_RichTextBox.Text = "The creator of the Bitcoin"; // Satoshi Nakamoto
                    break;
                case 20:
                    Question_RichTextBox.Text = "A state which is located in United States and the capital city is Nashville?"; // Tennessee
                    break;
                case 21:
                    Question_RichTextBox.Text = "The fourth biggest city of Netherlands"; // Utrecht
                    break;
                case 22:
                    Question_RichTextBox.Text = "Country whose capital is Hanoi"; // Vietnam
                    break;
                case 23:
                    Question_RichTextBox.Text = "Most famous video platform on web"; // YouTube
                    break;
                case 24:
                    Question_RichTextBox.Text = "The most known chinese technology brand, most known with the mobile phones they invent."; // Xiaomi
                    break;
                case 25:
                    Question_RichTextBox.Text = "The author of Hamlet, Macbeth, Romeo & Juliet etc..."; // William Shakespeare
                    break;
                case 26:
                    Question_RichTextBox.Text = "FINISHED!";
                    CrownButton.BackColor = Color.FromArgb(72, 106, 71);
                    break;
            }
        }

        private void Answer_TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Answer_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (questionNumber)
                {
                    case 1:
                        if (Answer_TextBox.Text == "Arkansas")
                        {
                            correctAnswer++;
                            AButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            AButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 2:
                        if (Answer_TextBox.Text == "Brazil")
                        {
                            correctAnswer++;
                            BButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            BButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 3:
                        if (Answer_TextBox.Text == "Cadillac")
                        {
                            correctAnswer++;
                            CButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            CButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 4:
                        if (Answer_TextBox.Text == "Dermatology")
                        {
                            correctAnswer++;
                            DButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            DButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 5:
                        if (Answer_TextBox.Text == "Ella Fitzgerald")
                        {
                            correctAnswer++;
                            EButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            EButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 6:
                        if (Answer_TextBox.Text == "Friday")
                        {
                            correctAnswer++;
                            FButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            FButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 7:
                        if (Answer_TextBox.Text == "Graham Bell")
                        {
                            correctAnswer++;
                            GButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            GButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 8:
                        if (Answer_TextBox.Text == "Homosexuality")
                        {
                            correctAnswer++;
                            HButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            HButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 9:

                        if (Answer_TextBox.Text == "İstanbul")
                        {
                            correctAnswer++;
                            İButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            İButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 10:
                        if (Answer_TextBox.Text == "Illinois")
                        {
                            correctAnswer++;
                            IButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            IButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 11:
                        if (Answer_TextBox.Text == "Jeff Bezos")
                        {
                            correctAnswer++;
                            JButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            JButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 12:
                        if (Answer_TextBox.Text == "Kleopatra")
                        {
                            correctAnswer++;
                            KButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            KButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 13:
                        if (Answer_TextBox.Text == "Linus Torvalds")
                        {
                            correctAnswer++;
                            LButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            LButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 14:
                        if (Answer_TextBox.Text == "Microsoft")
                        {
                            correctAnswer++;
                            MButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            MButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 15:
                        if (Answer_TextBox.Text == "Nigeria")
                        {
                            correctAnswer++;
                            NButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            NButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 16:
                        if (Answer_TextBox.Text == "Oregon")
                        {
                            correctAnswer++;
                            OButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            OButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 17:
                        if (Answer_TextBox.Text == "Pennysylvania")
                        {
                            correctAnswer++;
                            PButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            PButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 18:
                        if (Answer_TextBox.Text == "Redis")
                        {
                            correctAnswer++;
                            RButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            RButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 19:
                        if (Answer_TextBox.Text == "Satoshi Nakamoto")
                        {
                            correctAnswer++;
                            SButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            SButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 20:
                        if (Answer_TextBox.Text == "Tennessee")
                        {
                            correctAnswer++;
                            TButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            TButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 21:
                        if (Answer_TextBox.Text == "Utrecht")
                        {
                            correctAnswer++;
                            UButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            UButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 22:
                        if (Answer_TextBox.Text == "Vietnam")
                        {
                            correctAnswer++;
                            VButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            VButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 23:
                        if (Answer_TextBox.Text == "YouTube")
                        {
                            correctAnswer++;
                            YButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            YButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 24:
                        if (Answer_TextBox.Text == "Xiaomi")
                        {
                            correctAnswer++;
                            XButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            XButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                    case 25:
                        if (Answer_TextBox.Text == "William Shakespeare")
                        {
                            correctAnswer++;
                            WButton.BackColor = Color.FromArgb(72, 106, 71);
                        }
                        else
                        {
                            wrongAnswer++;
                            WButton.BackColor = Color.FromArgb(214, 26, 60);
                        }

                        Answer_TextBox.Clear();
                        break;
                }
            }
        }

        private void ExitPassaparola_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
