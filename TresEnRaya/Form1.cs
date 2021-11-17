using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TresEnRaya.Properties;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //{"0.0", "1.0", "2.0", "0.1", "1,1", "2.1", "0.2", "1.2", "2.2"}

        Random rd = new Random();

        private static List<String> x = new List<string>();
        private static List<String> o = new List<string>();
        private static List<String> btnUsados = new List<string>();
        private static List<String> btnPosibles = new List<string>() {"0.0", "1.0", "2.0", "0.1", "1.1", "2.1", "0.2", "1.2", "2.2" };
        private static Boolean acabado = false;

        private static String estadoPartida = "";

        private static int puntosX = 0;
        private static int puntosO = 0;

        private static int contTurnos = 1;


        

        private void btn0_0_Click(object sender, EventArgs e)
        {
            turno("0.0");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }               
                turno(maquina()); 
                evaluarTurno();   
            }
                     
        }

        private void btn1_0_Click(object sender, EventArgs e)
        {

            turno("1.0");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }





        }

        private void btn2_0_Click(object sender, EventArgs e)
        {
            turno("2.0");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }


        }

        private void btn0_1_Click(object sender, EventArgs e)
        {
            turno("0.1");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }


        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            turno("1.1");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }


        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            turno("2.1");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }

        }

        private void btn0_2_Click(object sender, EventArgs e)
        {
            turno("0.2");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }


        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            turno("1.2");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }



        }

        private void btn2_2_Click(object sender, EventArgs e)
        {

            turno("2.2");
            evaluarTurno();
            if (!acabado)
            {if (!checkFast.Checked) { Thread.Sleep(75); }
                turno(maquina()); 
                evaluarTurno();
            }


        }

        public void turno(String boton)
        {
            Console.WriteLine(" TURNO : " + contTurnos);
            String turno = "";
            if (contTurnos % 2 == 0)
            {
                Console.WriteLine("/////TURNO O/////");
                turno = "o";
            } else
            {
                Console.WriteLine("/////TURNO X/////");
                turno = "x";
            }

            contTurnos++;


            btnUsados.Add(boton);

            switch (boton)
            {
                case "0.0":
                    if (turno.Equals("o"))
                    {
                        btn0_0.Text = "o";
                        o.Add(boton);
                    } else
                    {
                        btn0_0.Text = "x";

                        x.Add(boton);
                    }
                    btn0_0.Enabled = false;
                break;

                case "0.1":
                    if (turno.Equals("o"))
                    {
                        btn0_1.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn0_1.Text = "x";

                        x.Add(boton);

                    }
                    btn0_1.Enabled = false;

                break;

                case "0.2":
                    if (turno.Equals("o"))
                    {
                        btn0_2.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn0_2.Text = "x";

                        x.Add(boton);

                    }
                    btn0_2.Enabled = false;

                break;

                case "1.0":
                    if (turno.Equals("o"))
                    {
                        btn1_0.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn1_0.Text = "x";

                        x.Add(boton);

                    }
                    btn1_0.Enabled = false;

                break;

                case "1.1":
                    if (turno.Equals("o"))
                    {
                        btn1_1.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn1_1.Text = "x";

                        x.Add(boton);

                    }
                    btn1_1.Enabled = false;

                break;

                case "1.2":
                    if (turno.Equals("o"))
                    {
                        btn1_2.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn1_2.Text = "x";

                        x.Add(boton);

                    }
                    btn1_2.Enabled = false;

                break;

                case "2.0":
                    if (turno.Equals("o"))
                    {
                        btn2_0.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {

                        btn2_0.Text = "x";

                        x.Add(boton);

                    }
                    btn2_0.Enabled = false;

                break;

                case "2.1":
                    if (turno.Equals("o"))
                    {
                        btn2_1.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn2_1.Text = "x";
                        x.Add(boton);


                    }
                    btn2_1.Enabled = false;

                break;

                case "2.2":
                    if (turno.Equals("o"))
                    {
                        btn2_2.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn2_2.Text = "x";
                        x.Add(boton);
                        

                    }
                    btn2_2.Enabled = false;

                break;
                default:
                break;

                


            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            contTurnos = 1;
            declararVictoriant();

            btn0_0.Text = "";
            btn1_1.Text = "";
            btn2_2.Text = "";
            btn0_1.Text = "";
            btn0_2.Text = "";
            btn1_0.Text = "";
            btn2_0.Text = "";
            btn2_1.Text = "";
            btn1_2.Text = "";

            lblVictoria.Text = "";

            x.Clear();
            o.Clear();
            btnUsados.Clear();
            acabado = false;


            
        }

        private void btnWTF_Click(object sender, EventArgs e)
        {
            txtResultados.ResetText();
            int numRegistros = 5;

            int contVicX = 0;
            int contVicO = 0;
            int contEmp = 0;

            if (textBox1.Enabled)
            {
                numRegistros = Int32.Parse(textBox1.Text);
            }

            for (int i = 1; i <= numRegistros; i++)
            {
                contTurnos = 1;

                btn0_0.Text = "";
                btn1_1.Text = "";
                btn2_2.Text = "";
                btn0_1.Text = "";
                btn0_2.Text = "";
                btn1_0.Text = "";
                btn2_0.Text = "";
                btn2_1.Text = "";
                btn1_2.Text = "";
                declararVictoriant();



                lblVictoria.Text = "";

                x.Clear();
                o.Clear();
                btnUsados.Clear();
                acabado = false;


                while (!acabado)
                {
                    if (!checkFast.Checked) { Thread.Sleep(75); }
                    turno(maquinaX());
                    evaluarTurno();

                    if (!checkFast.Checked) { Thread.Sleep(75); }

                    if (!acabado)
                    {
                        turno(maquina());

                        evaluarTurno();
                    }
                }

                String turnoCual = "";

                txtResultados.Text += ("**************************************");
                txtResultados.Text += Environment.NewLine;
                txtResultados.Text += ("PARTIDA " + i);
                txtResultados.Text += Environment.NewLine;


                for (int j = 1; j<=btnUsados.Count ; j++)
                {
                    if (j % 2 == 0 )
                    {
                        turnoCual = "O";
                    } else
                    {
                        turnoCual = "X";
                    }
                    txtResultados.Text += ("[" + j + "]  " + "Turno " + turnoCual + ": " + "{ " + btnUsados[j-1] + " }");
                    txtResultados.Text += Environment.NewLine;

                }

                txtResultados.Text += Environment.NewLine;

                switch (estadoPartida)
                {
                    case "EMPATE":
                        contEmp++;
                    break;

                    case "VICTORIA X":
                        contVicX++;
                    break;

                    case "VICTORIA O":
                        contVicO++;
                    break;
                }

                txtResultados.Text += (estadoPartida);
                txtResultados.Text += Environment.NewLine;
                txtResultados.Text += Environment.NewLine;



            }


            txtResultados.Text += ("**************************************");
            txtResultados.Text += Environment.NewLine;
            txtResultados.Text += "VICTORIAS X: " + contVicX;
            txtResultados.Text += Environment.NewLine;
            txtResultados.Text += "VICTORIAS O: " + contVicO;
            txtResultados.Text += Environment.NewLine;
            txtResultados.Text += "EMPATES: " + contEmp;



        }

        private void evaluarTurno()
        {
            String victoriaO = "GANA O";
            String victoriaX = "GANA X";

            Console.WriteLine(" ");
            Console.WriteLine("O:");

            for (int i = 0; i < o.Count(); i++) {
                Console.Write(o[i] + ", ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("X:");

            for (int i = 0; i < x.Count(); i++)
            {
                Console.Write(x[i] + ", ");

            }

            Console.WriteLine(" ");
            Console.WriteLine("Botones usados:");

            for (int i = 0; i < btnUsados.Count(); i++)
            {
                Console.Write(btnUsados[i] + ", ");

            }
            Console.WriteLine(" ");

            if ((x.Contains("0.0") && x.Contains("1.1") && x.Contains("2.2")) || (x.Contains("2.0") && x.Contains("1.1") && x.Contains("0.2")) ||
                (x.Contains("0.0") && x.Contains("0.1") && x.Contains("0.2")) || (x.Contains("1.0") && x.Contains("1.1") && x.Contains("1.2")) || (x.Contains("2.0") && x.Contains("2.1") && x.Contains("2.2")) ||
                (x.Contains("0.0") && x.Contains("1.0") && x.Contains("2.0")) || (x.Contains("0.1") && x.Contains("1.1") && x.Contains("2.1")) || (x.Contains("0.2") && x.Contains("1.2") && x.Contains("2.2")))
                {
                acabado = true;

                declararVictoria();
                    lblVictoria.Text = victoriaX;
                estadoPartida = "VICTORIA X";

                    puntosX++;
                lblO.Text = puntosO.ToString();
                lblX.Text = puntosX.ToString();
                }
                else if ((o.Contains("0.0") && o.Contains("1.1") && o.Contains("2.2")) || (o.Contains("2.0") && o.Contains("1.1") && o.Contains("0.2")) ||
                  (o.Contains("0.0") && o.Contains("0.1") && o.Contains("0.2")) || (o.Contains("1.0") && o.Contains("1.1") && o.Contains("1.2")) || (o.Contains("2.0") && o.Contains("2.1") && o.Contains("2.2")) ||
                  (o.Contains("0.0") && o.Contains("1.0") && o.Contains("2.0")) || (o.Contains("0.1") && o.Contains("1.1") && o.Contains("2.1")) || (o.Contains("0.2") && o.Contains("1.2") && o.Contains("2.2")))
                {
                acabado = true;

                declararVictoria();
                    lblVictoria.Text = victoriaO;
                estadoPartida = "VICTORIA O";
                
                puntosO++;
                lblO.Text = puntosO.ToString();
                lblX.Text = puntosX.ToString();
            } else if (contTurnos == 10)
                {
                acabado = true;

                declararVictoria();
                    lblVictoria.Text = "EMPATE";
                estadoPartida = "EMPATE";
                }
             

            


        }



        private void declararVictoriant()
        {
            btn0_0.Enabled = true;
            btn1_1.Enabled = true;
            btn2_2.Enabled = true;
            btn0_1.Enabled = true;
            btn0_2.Enabled = true;
            btn1_0.Enabled = true;
            btn2_0.Enabled = true;
            btn2_1.Enabled = true;
            btn1_2.Enabled = true;
        }

        private void declararVictoria()
        {
            btn0_0.Enabled = false;
            btn1_1.Enabled = false;
            btn2_2.Enabled = false;
            btn0_1.Enabled = false;
            btn0_2.Enabled = false;
            btn1_0.Enabled = false;
            btn2_0.Enabled = false;
            btn2_1.Enabled = false;
            btn1_2.Enabled = false;
        }

        /*
         *  
                 ||  ||  ||
                 ||  || )
         * 
         */

        private String maquina()
        {
            String decision = "";
            int btnSelect =0;
            Boolean repetido = true;
            List<String>btnIntentados = new List<string>();
            if (!btnUsados.Contains("1.1"))
            {
                decision = "1.1";
            } else if ((x.Contains("1.0") && x.Contains("2.1") && !btnUsados.Contains("2.0")))
            {
                decision = "2.0";
            }
            else if ((x.Contains("2.1") && x.Contains("1.2") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("1.2") && x.Contains("0.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((x.Contains("0.1") && x.Contains("1.0") && !btnUsados.Contains("0.0")))
            {
                decision = "0.0";
            }
            else if ((o.Contains("0.0") && o.Contains("1.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((o.Contains("0.0") && !btnUsados.Contains("1.1") && o.Contains("2.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.0") && o.Contains("1.1") && o.Contains("2.2")))
            {
                decision = "0.0";
            }
            else if ((o.Contains("2.0") && o.Contains("1.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((o.Contains("2.0") && !btnUsados.Contains("1.1") && o.Contains("0.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("2.0") && o.Contains("1.1") && o.Contains("0.2")))
            {
                decision = "2.0";
            }
            else if ((o.Contains("0.0") && o.Contains("0.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((o.Contains("0.0") && !btnUsados.Contains("0.1") && o.Contains("0.2")))
            {
                decision = "0.1";
            }
            else if ((!btnUsados.Contains("0.0") && o.Contains("0.1") && o.Contains("0.2")))
            {
                decision = "0.0";
            }
            else if ((o.Contains("1.0") && o.Contains("1.1") && !btnUsados.Contains("1.2")))
            {
                decision = "1.2";
            }
            else if ((o.Contains("1.0") && !btnUsados.Contains("1.1") && o.Contains("1.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("1.0") && o.Contains("1.1") && o.Contains("1.2")))
            {
                decision = "1.0";
            }
            else if ((o.Contains("2.0") && o.Contains("2.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((o.Contains("2.0") && !btnUsados.Contains("2.1") && o.Contains("2.2")))
            {
                decision = "2.1";
            }
            else if ((!btnUsados.Contains("2.0") && o.Contains("2.1") && o.Contains("2.2")))
            {
                decision = "2.0";
            }
            else if ((o.Contains("0.0") && o.Contains("1.0") && !btnUsados.Contains("2.0")))
            {
                decision = "2.0";
            }
            else if ((o.Contains("0.0") && !btnUsados.Contains("1.0") && o.Contains("2.0")))
            {
                decision = "1.0";
            }
            else if ((!btnUsados.Contains("0.0") && o.Contains("1.0") && o.Contains("2.0")))
            {
                decision = "0.0";
            }
            else if ((o.Contains("0.1") && o.Contains("1.1") && !btnUsados.Contains("2.1")))
            {
                decision = "2.1";
            }
            else if ((o.Contains("0.1") && !btnUsados.Contains("1.1") && o.Contains("2.1")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.1") && o.Contains("1.1") && o.Contains("2.1")))
            {
                decision = "0.1";
            }
            else if ((o.Contains("0.2") && o.Contains("1.2") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((o.Contains("0.2") && !btnUsados.Contains("1.2") && o.Contains("2.2")))
            {
                decision = "1.2";
            }
            else if ((!btnUsados.Contains("0.2") && o.Contains("1.2") && o.Contains("2.2")))
            {
                decision = "0.2";
            }
            else if ((x.Contains("0.0") && x.Contains("0.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((x.Contains("0.0") && !btnUsados.Contains("0.1") && x.Contains("0.2")))
            {
                decision = "0.1";
            }
            else if ((!btnUsados.Contains("0.0") && x.Contains("0.1") && x.Contains("0.2")))
            {
                decision = "0.0";
            }
            else if ((x.Contains("1.0") && x.Contains("1.1") && !btnUsados.Contains("1.2")))
            {
                decision = "1.2";
            }
            else if ((x.Contains("1.0") && !btnUsados.Contains("1.1") && x.Contains("1.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("1.0") && x.Contains("1.1") && x.Contains("1.2")))
            {
                decision = "1.0";
            }
            else if ((x.Contains("2.0") && x.Contains("2.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("2.0") && !btnUsados.Contains("2.1") && x.Contains("2.2")))
            {
                decision = "2.1";
            }
            else if ((!btnUsados.Contains("2.0") && x.Contains("2.1") && x.Contains("2.2")))
            {
                decision = "2.0";
            }
            else if ((x.Contains("0.0") && x.Contains("1.0") && !btnUsados.Contains("2.0")))
            {
                decision = "2.0";
            }
            else if ((x.Contains("0.0") && !btnUsados.Contains("1.0") && x.Contains("2.0")))
            {
                decision = "1.0";
            }
            else if ((!btnUsados.Contains("0.0") && x.Contains("1.0") && x.Contains("2.0")))
            {
                decision = "0.0";
            }
            else if ((x.Contains("0.1") && x.Contains("1.1") && !btnUsados.Contains("2.1")))
            {
                decision = "2.1";
            }
            else if ((x.Contains("0.1") && !btnUsados.Contains("1.1") && x.Contains("2.1")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.1") && x.Contains("1.1") && x.Contains("2.1")))
            {
                decision = "0.1";
            }
            else if ((x.Contains("0.2") && x.Contains("1.2") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("0.2") && !btnUsados.Contains("1.2") && x.Contains("2.2")))
            {
                decision = "1.2";
            }
            else if ((!btnUsados.Contains("0.2") && x.Contains("1.2") && x.Contains("2.2")))
            {
                decision = "0.2";
            }
            else if (x.Contains("1.1") && !btnUsados.Contains("0.0"))
            {
                decision = "0.0";
            }
            else if (x.Contains("1.1") && !btnUsados.Contains("2.0"))
            {
                decision = "2.0";
            }
            else if (x.Contains("1.1") && !btnUsados.Contains("0.2"))
            {
                decision = "0.2";
            }
            else if (x.Contains("1.1") && !btnUsados.Contains("2.2"))
            {
                decision = "2.2";
            }
            else if ((x.Contains("0.0") && x.Contains("1.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("0.0") && !btnUsados.Contains("1.1") && x.Contains("2.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.0") && x.Contains("1.1") && x.Contains("2.2")))
            {
                decision = "0.0";
            }
            else if ((x.Contains("2.0") && x.Contains("1.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((x.Contains("2.0") && !btnUsados.Contains("1.1") && x.Contains("0.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("2.0") && x.Contains("1.1") && x.Contains("0.2")))
            {
                decision = "2.0";
            }
            else if (x.Contains("0.0") && x.Contains("2.2") && !btnUsados.Contains("1.0"))
            {
                decision = "1.0";
            }
            else if (x.Contains("0.0") && x.Contains("2.2") && !btnUsados.Contains("2.1"))
            {
                decision = "2.1";
            }
            else if (x.Contains("0.0") && x.Contains("2.2") && !btnUsados.Contains("0.1"))
            {
                decision = "0.1";
            }
            else if (x.Contains("0.0") && x.Contains("2.2") && !btnUsados.Contains("1.2"))
            {
                decision = "1.2";
            }
            else if (x.Contains("2.0") && x.Contains("0.2") && !btnUsados.Contains("1.0"))
            {
                decision = "1.0";
            }
            else if (x.Contains("2.0") && x.Contains("0.2") && !btnUsados.Contains("2.1"))
            {
                decision = "2.1";
            }
            else if (x.Contains("2.0") && x.Contains("0.2") && !btnUsados.Contains("0.1"))
            {
                decision = "0.1";
            }
            else if (x.Contains("2.0") && x.Contains("0.2") && !btnUsados.Contains("1.2"))
            {
                decision = "1.2";
            } 
            else if (x.Contains("2.2") && x.Contains("0.1") && !btnUsados.Contains("0.2")) 
            {
                decision = "0.2";
            }
            else if (x.Contains("0.2") && x.Contains("1.0") && !btnUsados.Contains("0.0"))
            {
                decision = "0.0";
            }
            else if (x.Contains("0.0") && x.Contains("2.1") && !btnUsados.Contains("2.0"))
            {
                decision = "2.0";
            }
            else if (x.Contains("2.0") && x.Contains("1.2") && !btnUsados.Contains("2.2"))
            {
                decision = "2.2";
            }
            else if (x.Contains("0.2") && x.Contains("2.1") && !btnUsados.Contains("2.2"))
            {
                decision = "2.2";
            }
            else if (x.Contains("2.2") && x.Contains("1.0") && !btnUsados.Contains("2.0"))
            {
                decision = "2.0";
            }
            else if (x.Contains("2.0") && x.Contains("0.1") && !btnUsados.Contains("0.0"))
            {
                decision = "0.0";
            }
            else if (x.Contains("0.0") && x.Contains("1.2") && !btnUsados.Contains("0.2"))
            {
                decision = "0.2";
            }
            else
            {
                decision = decisionRandom();
            }
            
                          
            return decision;
            
        }

        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        private String maquinaX()
        {
            String decision = "";
           
            Random rdJugada = new Random();
            int jugada;
            int arista;
            int esquina;
            /*if (!btnUsados.Contains("1.1"))
            {
                decision = "1.1";
            }*/



            if (contTurnos <= 2)
            {
                jugada = rdJugada.Next(1, 4);
                if (jugada == 1)
                {
                    Console.Write("*** JUGADA 1 ***");
                    decision = "1.1";
                }
                else if (jugada == 2)
                {
                    Console.Write("*** JUGADA 2 ***");

                    arista = rdJugada.Next(1, 5);

                    if (arista == 1)
                    {
                        decision = "1.0";
                    }
                    else if (arista == 2)
                    {
                        decision = "2.1";
                    }
                    else if (arista == 3)
                    {
                        decision = "1.2";
                    }
                    else if (arista == 4)
                    {
                        decision = "0.2";
                    }
                }
                else if (jugada == 3)
                {
                    Console.Write("*** JUGADA 3 ***");

                    esquina = rdJugada.Next(1, 5);

                    if (esquina == 1)
                    {
                        decision = "0.0";
                    }
                    else if (esquina == 2)
                    {
                        decision = "2.0";
                    }
                    else if (esquina == 3)
                    {
                        decision = "2.2";
                    }
                    else if (esquina == 4)
                    {
                        decision = "0.2";
                    }
                }


            }
            else if (contTurnos <= 4)
            {
                if (x.Contains("1.0") && !btnUsados.Contains("2.1"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "2.1";
                }
                else if (x.Contains("2.1") && !btnUsados.Contains("1.2"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "1.2";
                }
                else if (x.Contains("1.2") && !btnUsados.Contains("0.1"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "0.1";
                }
                else if (x.Contains("0.1") && !btnUsados.Contains("1.0"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "1.0";
                }
                else if (!btnUsados.Contains("1.0") && x.Contains("2.1"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "1.0";
                }
                else if (!btnUsados.Contains("2.1") && x.Contains("1.2"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "2.1";
                }
                else if (!btnUsados.Contains("1.2") && x.Contains("0.1"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "1.2";
                }
                else if (!btnUsados.Contains("0.1") && x.Contains("1.0"))
                {
                    Console.WriteLine("******* SEGUIMOS CON LA JUGADA 2 *******");
                    decision = "0.1";
                }
                else
                    decision = decisionRandom();


            }


            else if ((x.Contains("1.0") && x.Contains("2.1") && !btnUsados.Contains("2.0")))
            {
                decision = "2.0";
            }
            else if ((x.Contains("2.1") && x.Contains("1.2") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("1.2") && x.Contains("0.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((x.Contains("0.1") && x.Contains("1.0") && !btnUsados.Contains("0.0")))
            {
                decision = "0.0";
            }

            // DIAGONAL 1 GANAR

            else if ((x.Contains("0.0") && x.Contains("1.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("0.0") && !btnUsados.Contains("1.1") && x.Contains("2.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.0") && x.Contains("1.1") && x.Contains("2.2")))
            {
                decision = "0.0";
            }

            // DIAGONAL 2 GANAR

            else if ((x.Contains("2.0") && x.Contains("1.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((x.Contains("2.0") && !btnUsados.Contains("1.1") && x.Contains("0.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("2.0") && x.Contains("1.1") && x.Contains("0.2")))
            {
                decision = "2.0";
            }

            // VERTICAL 1 GANAR

            else if ((x.Contains("0.0") && x.Contains("0.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((x.Contains("0.0") && !btnUsados.Contains("0.1") && x.Contains("0.2")))
            {
                decision = "0.1";
            }
            else if ((!btnUsados.Contains("0.0") && x.Contains("0.1") && x.Contains("0.2")))
            {
                decision = "0.0";
            }

            // VERITCAL 2 GANAR

            else if ((x.Contains("1.0") && x.Contains("1.1") && !btnUsados.Contains("1.2")))
            {
                decision = "1.2";
            }
            else if ((x.Contains("1.0") && !btnUsados.Contains("1.1") && x.Contains("1.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("1.0") && x.Contains("1.1") && x.Contains("1.2")))
            {
                decision = "1.0";
            }

            // VERTICAL 3 GANAR
            else if ((x.Contains("2.0") && x.Contains("2.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("2.0") && !btnUsados.Contains("2.1") && x.Contains("2.2")))
            {
                decision = "2.1";
            }
            else if ((!btnUsados.Contains("2.0") && x.Contains("2.1") && x.Contains("2.2")))
            {
                decision = "2.0";
            }

            // HORIZONTAL 1 GANAR
            else if ((x.Contains("0.0") && x.Contains("1.0") && !btnUsados.Contains("2.0")))
            {
                decision = "2.0";
            }
            else if ((x.Contains("0.0") && !btnUsados.Contains("1.0") && x.Contains("2.0")))
            {
                decision = "1.0";
            }
            else if ((!btnUsados.Contains("0.0") && x.Contains("1.0") && x.Contains("2.0")))
            {
                decision = "0.0";
            }

            // HORIZONTAL 2 GANAR
            else if ((x.Contains("0.1") && x.Contains("1.1") && !btnUsados.Contains("2.1")))
            {
                decision = "2.1";
            }
            else if ((x.Contains("0.1") && !btnUsados.Contains("1.1") && x.Contains("2.1")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.1") && x.Contains("1.1") && x.Contains("2.1")))
            {
                decision = "0.1";
            }

            // HORIZONTAL 3 GANAR

            else if ((x.Contains("0.2") && x.Contains("1.2") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((x.Contains("0.2") && !btnUsados.Contains("1.2") && x.Contains("2.2")))
            {
                decision = "1.2";
            }
            else if ((!btnUsados.Contains("0.2") && x.Contains("1.2") && x.Contains("2.2")))
            {
                decision = "0.2";
            }

            // CONTRAATAQUE ARISTAS

            else if ((o.Contains("1.0") && o.Contains("2.1") && !btnUsados.Contains("2.0")))
            {
                decision = "2.0";
            }
            else if ((o.Contains("2.1") && o.Contains("1.2") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((o.Contains("1.2") && o.Contains("0.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((o.Contains("0.1") && o.Contains("1.0") && !btnUsados.Contains("0.0")))
            {
                decision = "0.0";
            }

            // DIAGONAL 1 CONTRA

            else if ((o.Contains("0.0") && o.Contains("1.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((o.Contains("0.0") && !btnUsados.Contains("1.1") && o.Contains("2.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.0") && o.Contains("1.1") && o.Contains("2.2")))
            {
                decision = "0.0";
            }

            // DIAGONAL 2 CONTRA

            else if ((o.Contains("2.0") && o.Contains("1.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((o.Contains("2.0") && !btnUsados.Contains("1.1") && o.Contains("0.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("2.0") && o.Contains("1.1") && o.Contains("0.2")))
            {
                decision = "2.0";
            }

            // VERTICAL 1 CONTRA

            else if ((o.Contains("0.0") && o.Contains("0.1") && !btnUsados.Contains("0.2")))
            {
                decision = "0.2";
            }
            else if ((o.Contains("0.0") && !btnUsados.Contains("0.1") && o.Contains("0.2")))
            {
                decision = "0.1";
            }
            else if ((!btnUsados.Contains("0.0") && o.Contains("0.1") && o.Contains("0.2")))
            {
                decision = "0.0";
            }

            // VERTICAL 2 CONTRA

            else if ((o.Contains("1.0") && o.Contains("1.1") && !btnUsados.Contains("1.2")))
            {
                decision = "1.2";
            }
            else if ((o.Contains("1.0") && !btnUsados.Contains("1.1") && o.Contains("1.2")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("1.0") && o.Contains("1.1") && o.Contains("1.2")))
            {
                decision = "1.0";
            }

            // VERTICAL 3 CONTRA

            else if ((o.Contains("2.0") && o.Contains("2.1") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((o.Contains("2.0") && !btnUsados.Contains("2.1") && o.Contains("2.2")))
            {
                decision = "2.1";
            }
            else if ((!btnUsados.Contains("2.0") && o.Contains("2.1") && o.Contains("2.2")))
            {
                decision = "2.0";
            }

            // HORIZONTAL 1 CONTRA

            else if ((o.Contains("0.0") && o.Contains("1.0") && !btnUsados.Contains("2.0")))
            {
                decision = "2.0";
            }
            else if ((o.Contains("0.0") && !btnUsados.Contains("1.0") && o.Contains("2.0")))
            {
                decision = "1.0";
            }
            else if ((!btnUsados.Contains("0.0") && o.Contains("1.0") && o.Contains("2.0")))
            {
                decision = "0.0";
            }

            // HORIZONTAL 2 CONTRA 

            else if ((o.Contains("0.1") && o.Contains("1.1") && !btnUsados.Contains("2.1")))
            {
                decision = "2.1";
            }
            else if ((o.Contains("0.1") && !btnUsados.Contains("1.1") && o.Contains("2.1")))
            {
                decision = "1.1";
            }
            else if ((!btnUsados.Contains("0.1") && o.Contains("1.1") && o.Contains("2.1")))
            {
                decision = "0.1";
            }

            // HORIZONTAL 3 CONTRA 

            else if ((o.Contains("0.2") && o.Contains("1.2") && !btnUsados.Contains("2.2")))
            {
                decision = "2.2";
            }
            else if ((o.Contains("0.2") && !btnUsados.Contains("1.2") && o.Contains("2.2")))
            {
                decision = "1.2";
            }
            else if ((!btnUsados.Contains("0.2") && o.Contains("1.2") && o.Contains("2.2")))
            {
                decision = "0.2";
            }

            // CONTRA ESQUINAS CENTRO

            else if (o.Contains("1.1") && !btnUsados.Contains("0.0"))
            {
                decision = "0.0";
            }
            else if (o.Contains("1.1") && !btnUsados.Contains("2.0"))
            {
                decision = "2.0";
            }
            else if (o.Contains("1.1") && !btnUsados.Contains("0.2"))
            {
                decision = "0.2";
            }
            else if (o.Contains("1.1") && !btnUsados.Contains("2.2"))
            {
                decision = "2.2";
            }


            // CONTRA ESQUINAS 1
            else if (o.Contains("0.0") && o.Contains("2.2") && !btnUsados.Contains("1.0"))
            {
                decision = "1.0";
            }
            else if (o.Contains("0.0") && o.Contains("2.2") && !btnUsados.Contains("2.1"))
            {
                decision = "2.1";
            }
            else if (o.Contains("0.0") && o.Contains("2.2") && !btnUsados.Contains("0.1"))
            {
                decision = "0.1";
            }
            else if (o.Contains("0.0") && o.Contains("2.2") && !btnUsados.Contains("1.2"))
            {
                decision = "1.2";
            }

            // CONTRA ESQUINAS 2

            else if (o.Contains("2.0") && o.Contains("0.2") && !btnUsados.Contains("1.0"))
            {
                decision = "1.0";
            }
            else if (o.Contains("2.0") && o.Contains("0.2") && !btnUsados.Contains("2.1"))
            {
                decision = "2.1";
            }
            else if (o.Contains("2.0") && o.Contains("0.2") && !btnUsados.Contains("0.1"))
            {
                decision = "0.1";
            }
            else if (o.Contains("2.0") && o.Contains("0.2") && !btnUsados.Contains("1.2"))
            {
                decision = "1.2";
            }

            // CONTRA L 1

            else if (o.Contains("2.2") && o.Contains("0.1") && !btnUsados.Contains("0.2"))
            {
                decision = "0.2";
            }
            else if (o.Contains("0.2") && o.Contains("1.0") && !btnUsados.Contains("0.0"))
            {
                decision = "0.0";
            }
            else if (o.Contains("0.0") && o.Contains("2.1") && !btnUsados.Contains("2.0"))
            {
                decision = "2.0";
            }
            else if (o.Contains("2.0") && o.Contains("1.2") && !btnUsados.Contains("2.2"))
            {
                decision = "2.2";
            }

            // CONTRA L 2

            else if (o.Contains("0.2") && o.Contains("2.1") && !btnUsados.Contains("2.2"))
            {
                decision = "2.2";
            }
            else if (o.Contains("2.2") && o.Contains("1.0") && !btnUsados.Contains("2.0"))
            {
                decision = "2.0";
            }
            else if (o.Contains("2.0") && o.Contains("0.1") && !btnUsados.Contains("0.0"))
            {
                decision = "0.0";
            }
            else if (o.Contains("0.0") && o.Contains("1.2") && !btnUsados.Contains("0.2"))
            {
                decision = "0.2";
            }
            else
            {
                decision = decisionRandom();

            }  


            return decision;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            textBox1.Enabled = false;
            

            
        }

        private String decisionRandom ()
        {
            int btnSelect = 0;
            Boolean repetido = true;
            List<String> btnIntentados = new List<string>();
            String decision = "";
            do
            {
                btnSelect = rd.Next(0, 9);
                /* Console.WriteLine(" ");
                 Console.WriteLine("id decision maquina: " + btnSelect);
                 Console.WriteLine(" ");*/

                decision = btnPosibles[btnSelect];
                /*Console.WriteLine(" ");
                Console.WriteLine("decision maquina: " + decision);
                Console.WriteLine(" ");*/
                if (!btnIntentados.Contains(decision))
                {
                    btnIntentados.Add(decision);

                }

                if (btnIntentados.Count() > 9)
                {
                    acabado = true;
                    decision = "no ha pasado";

                }

                if (!btnUsados.Contains(decision) || btnIntentados.Count() >= 9)
                {
                    repetido = false;
                }

                /*Console.WriteLine("Botones intentados:");

                 for (int i = 0; i < btnIntentados.Count(); i++)
                 {
                     Console.Write(btnIntentados[i] + ", ");

                 }
                 Console.WriteLine(" ");*/

            } while (repetido);

            return decision;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!Char.IsNumber(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
            {
                e.Handled = true;
            }
        }

        private void checkInformes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInformes.Checked)
            {
                textBox1.Enabled = true;
            } else
            {
                textBox1.Text = "5";
                textBox1.Enabled = false;

            }
        }

        
    }
}