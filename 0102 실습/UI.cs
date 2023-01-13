using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0102_실습
{
    public class UI
    {
        public int m_Height;
        public int m_Width;
        public string[,] m_Scale;


        public void SetScale()
        {
            m_Scale = new string[m_Height, m_Width];
        } // void SetScale()

        public void SetPaint()
        {
            for(int i = 0; i < m_Height; i++)
            {
                for(int j = 0; j < m_Width; j++)
                {
                    if(i == 0 || i == m_Height - 1)
                    {
                        m_Scale[i, j] = "■";
                    }
                    else if (j == 0 || j == m_Width - 1)
                    {
                        m_Scale[i, j] = "■";
                    }
                    else if(i == 15 || i ==30)
                    {
                        m_Scale[i, j] = "■";
                    }
                    else
                    {
                        m_Scale[i, j] = "  ";
                    }
                }
            }
        } // void SetPaint()
    } // class UI



    public class MAX_FRAME : UI
    {
        public MAX_FRAME()
        {
            m_Height = 46;
            m_Width = 60;

            SetScale();
            SetPaint();

        } // MAX_SCALE()
    } // class MAX_SCALE : UI



  






 




    public class CARDS_FRAME
    {
        public int m_CHeight = 14;
        public int m_CWidth = 9;
        public string[,] m_CScale;

        public CARDS_FRAME()
        {
            SetCardScale();
        } // CARDS_FRAME()

        public void SetCardScale()
        {
            m_CScale = new string[m_CHeight, m_CWidth];
        } // void SetCardScale()

        public void SetCardPaint(string _Mark, string _stringNum)
        {
            for(int i = 0; i < m_CHeight; i++)
            {
                for(int j = 0; j < m_CWidth; j++)
                {
                    if(i == 0 || i == m_CHeight -1)
                    {
                        m_CScale[i, j] = "──";
                    }
                    else if(j == 0)
                    {
                        m_CScale[i, j] = "│ ";
                    }
                    else if (j == m_CWidth - 1)
                    {
                        m_CScale[i, j] = " │";
                    }
                    else if((i == 1 && j == 1) || (i == m_CHeight-2 && j == m_CWidth - 2))
                    {
                        m_CScale[i, j] = _Mark;
                    }
                    else if((i == 1 && j == m_CWidth - 2) || (i == m_CHeight - 2 && j == 1))
                    {
                        m_CScale[i, j] = _stringNum;
                    }
                    else
                    {
                        m_CScale[i, j] = "  ";
                    }
                }
            }

            m_CScale[0, 0] = "┌─";
            m_CScale[0, m_CWidth -1] = "─┐";
            m_CScale[m_CHeight -1, 0] = "└─";
            m_CScale[m_CHeight - 1, m_CWidth - 1] = "─┘";

            



        } // SetCardPaint()






        

    } // class CARDS_FRAME




    public class CARDS_BACK
    {
        public int m_CHeight = 14;
        public int m_CWidth = 9;
        public string[,] m_CScale;

        public CARDS_BACK()
        {
            SetCardScale();
            SetCardPaint();
        } // CARDS_FRAME()

        public void SetCardScale()
        {
            m_CScale = new string[m_CHeight, m_CWidth];
        } // void SetCardScale()

        public void SetCardPaint()
        {
            for (int i = 0; i < m_CHeight; i++)
            {
                for (int j = 0; j < m_CWidth; j++)
                {
                    if (i == 0 || i == m_CHeight - 1)
                    {
                        m_CScale[i, j] = "──";
                    }
                    else if (j == 0)
                    {
                        m_CScale[i, j] = "│ ";
                    }
                    else if (j == m_CWidth - 1)
                    {
                        m_CScale[i, j] = " │";
                    }
                    else
                    {
                        m_CScale[i, j] = "▒▒";
                    }
                }
            }

            m_CScale[0, 0] = "┌─";
            m_CScale[0, m_CWidth - 1] = "─┐";
            m_CScale[m_CHeight - 1, 0] = "└─";
            m_CScale[m_CHeight - 1, m_CWidth - 1] = "─┘";





        } // SetCardPaint()








    } // class CARDS_FRAME







} // END
