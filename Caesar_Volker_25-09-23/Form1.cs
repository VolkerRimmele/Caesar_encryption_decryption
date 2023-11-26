namespace Caesar_Volker_25_09_23
//Bearbeitet und Kommentiert 26.11.23
{
    public partial class Form1 : Form
    {
        int encryptArt = 0;//Gibt den Grad der Verschlüsselung an z.B 1 aus A wird B oder -2 aus F wird D usw
        string encryptAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz.,!? ";
       
        public Form1()
        {
            InitializeComponent();
        }


        private void lst_Box_Click(object sender, EventArgs e)
        {

            encryptArt = 10 + ((int)lst_Box.SelectedIndex * (-1));
            //Bei der List Box ist das Obere Feld (in der Anzeige 10) der Index 0, des zweite Feld von
            //oben (in der Anzeige 9) ist der Index 1 usw.
            //Deshalb 10 + (index * -1) um die richtigen Werte auszulesen - (zusätzlich casting mit int)
        }


        public void btn_Encrypt_Click(object sender, EventArgs e)
        //Wenn der Verschlüsselungs Button gedückt wird
        {
            for (int i = 0; i < txt_Input.Text.Length; i++)
            //für jeden eingegebenen Buchstaben i (äußere Schleife)
            //wird das encrypt Alphabet durchlaufen (inner Schleife) bis es 2 mal den gleichen Buchstaben gibt.
            //Dann wird auf den Buchstaben die Variable encryptArt addiert und das Ganze in das Output Feld
            //txt_Output.Text geschrieben.
            {
                for (int j = 0; j < encryptAlphabet.Length; j++)
                {
                    if (txt_Input.Text[i] == encryptAlphabet[j])
                    {

                        if (j + encryptArt < 0)//kann auftreten wenn encryptArt negativ z.B. Bei A und -1.
                        //in diesen Fall muss encryptAlphabet dann dazuaddiert werden um encrypAlphabet dann von
                        //hinten nach vorne zu durchlaufen
                        {
                            txt_Output.Text = txt_Output.Text + (char)((int)encryptAlphabet[j + encryptArt + encryptAlphabet.Length]);
                            break;
                        }
                        else if (j + encryptArt < encryptAlphabet.Length)//Sozusagen der Normalfall. Der eingegeben Buchstabe
                        //plus der Verschiebung um encryptArt ist innerhalb des definierten encryptAlphabet.

                        {
                            txt_Output.Text = txt_Output.Text + (char)((int)encryptAlphabet[j + encryptArt]);
                            break;
                        }
                        //Das encrytlAlphabet ist zu kurz z.b. bei ?+10. In diesen Fall muss das encryptAlphabet wieder
                        //von vorne durchlaufen werden deshalb -encryptAlphabet.
                        else if (j + encryptArt >= encryptAlphabet.Length)
                        {
                            txt_Output.Text = txt_Output.Text + (char)((int)encryptAlphabet[j + encryptArt - encryptAlphabet.Length]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hier ging was schief");
                            break;
                        }
                    }
                }
            }
        }

        //Dieser Teil ist so programmiert das für Ver- und Entschlüsseln die gleiche EncrypArt eingestellt sein muss

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < txt_Output.Text.Length; i++)
            {
                for (int j = 0; j < encryptAlphabet.Length; j++)
                {
                    if (txt_Output.Text[i] == encryptAlphabet[j])
                    {
                        ////plainTextArray[i] = (char)(((int)encryptAlphabetArray[j]) + encryptArt);
                        if (j - encryptArt < 0)
                        {
                            txt_Ent.Text = txt_Ent.Text + (char)((int)encryptAlphabet[j - encryptArt + encryptAlphabet.Length]);
                            break;
                        }
                        else if (j - encryptArt < encryptAlphabet.Length)
                        {
                            txt_Ent.Text = txt_Ent.Text + (char)((int)encryptAlphabet[j - encryptArt]);
                            break;
                        }
                        else if (j - encryptArt >= encryptAlphabet.Length)
                        {
                            txt_Ent.Text = txt_Ent.Text + (char)((int)encryptAlphabet[j - encryptArt - encryptAlphabet.Length]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hier ging was schief");
                            break;
                        }
                    }
                }
            }
        }


        private void btn_Ende_Click(object sender, EventArgs e)//Beenden des Programmes per Click
        {
            Close();
        }

        private void btn_FelderLeeren_Click(object sender, EventArgs e)//Alle Text Felder werden leergemacht
        {
            txt_Input.Text = "";
            txt_Output.Text = "";
            txt_Ent.Text = "";
        }
    }
}