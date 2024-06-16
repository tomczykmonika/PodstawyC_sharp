using PodstawyC_.Module1;
using PodstawyC_.Module2;
using PodstawyC_.Module3;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PodstawyC_sharp
    {

    #region ProgramClassRegion
    class Program
    {
        /// <summary>
        /// main method description - wyświetla się przy metodzie
        /// </summary>
        /// <param name="args">args description</param>
        private static void Main(string[] args)
        {

            // *** MODUŁ 1:
            //Podstawy.WriteAndRead();
            //Podstawy.TypyZmiennych();
            //Podstawy.Operatory();
            //Podstawy.KonwersjaTypow();
            //Podstawy.NullableType();
            //Podstawy.TryCatch();
            //Podstawy.RegexExpression();

            //IfElseStatment.IF_cwiczenia();

            //SwitchInstruction.Switch_cwiczenia();

            //cwiczenieBMI.BMI();

            //TablicePetle.TabPetPrzyklady();

            //cwiczenieIterowanie.iteracja();

            //enumCwiczenia.GenderCwiczenie();

            //ParsowanieDaty.ParsDateCwiczenie();


            //// *** MODUŁ 2:

            //Person.PersonExample();

            //// * Klasy abstrakcyjne i interface'y

            //ExcelFile excelFile = new ExcelFile();
            //excelFile.CreatedOn = DateTime.Now;
            //excelFile.FileName = "excel-file";
            //excelFile.GenerateReport();

            //WordFile wordFile = new WordFile();
            //wordFile.CreatedOn = DateTime.Now;
            //wordFile.FileName = "word-file";
            //wordFile.Print();

            //// * Polimorfizm

            //Shape[] shapes = { new Circle(), new Rectangle(), new Triangle() };

            //foreach (Shape shape in shapes)
            //{
            //    shape.Draw();
            //}


            // *** MODUŁ 3:
            Listy.ListyExample();

        }
    }
    #endregion
}