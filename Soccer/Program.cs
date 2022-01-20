using Soccer.Logic;
using System;

namespace Soccer
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t1 = new Team("A");
            t1.AddPlayer(new Player(6, 2, 10, 5, "Rysiek"));
            t1.AddPlayer(new Player(5, 3, 4, 5, "Krzysiek"));
            t1.AddPlayer(new Player(10, 10, 10, 10, "Jo"));
            t1.AddPlayer(new Player(4, 8, 9, 5, "Mama"));
            t1.AddPlayer(new Player(6, 2, 6, 7, "Tata"));
            t1.AddPlayer(new Player(2, 1, 7, 9, "Jo2"));
            t1.AddPlayer(new Player(5, 10, 4, 10, "Ptys"));
            t1.AddPlayer(new Player(8, 9, 10, 7, "Krawczyk"));
            t1.AddPlayer(new Player(9, 8, 7, 6, "Krzystof"));
            t1.AddPlayer(new Player(5, 4, 3, 2, "Szymon"));
            t1.AddPlayer(new Player(8, 4, 2, 8, "Rajmund"));
            t1.AddPlayer(new Player(9, 5, 4, 2, "Jo3"));
            t1.AddPlayer(new Player(6, 2, 10, 5, "Rysiek2"));
            t1.AddPlayer(new Player(5, 3, 4, 5, "Krzysiek2"));
            t1.AddPlayer(new Player(10, 10, 10, 10, "Jo4"));
            t1.AddPlayer(new Player(4, 8, 9, 5, "Mama2"));
            t1.AddPlayer(new Player(6, 2, 6, 7, "Tata2"));
            t1.AddPlayer(new Player(2, 1, 7, 9, "Jo5"));
            t1.AddPlayer(new Player(5, 10, 4, 10, "Ptys2"));
            t1.AddPlayer(new Player(8, 9, 10, 7, "Krawczyk2"));
            t1.AddPlayer(new Player(9, 8, 7, 6, "Krzystof2"));
            t1.AddPlayer(new Player(5, 4, 3, 2, "Szymon2"));
            t1.AddPlayer(new Player(8, 4, 2, 8, "Rajmund2"));
            t1.AddPlayer(new Player(9, 5, 4, 2, "Jo6"));

            Team t2 = new Team("B");
            t2.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t2.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t2.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t2.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t2.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t2.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t2.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t2.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t2.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t2.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t2.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t2.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t2.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t2.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t2.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t2.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t2.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t2.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t2.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t2.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t2.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t2.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t2.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t2.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t3 = new Team("C");
            t3.AddPlayer(new Player(10, 10, 10, 10, "Marek"));
            t3.AddPlayer(new Player(10, 10, 4, 5, "Krysia"));
            t3.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t3.AddPlayer(new Player(10, 10, 8, 5, "Danka"));
            t3.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t3.AddPlayer(new Player(10, 10, 2, 1, "Dzozef"));
            t3.AddPlayer(new Player(10, 10, 10, 2, "Karol"));
            t3.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t3.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t3.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t3.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t3.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t3.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t3.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t3.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t3.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t3.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t3.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t3.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t3.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t3.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t3.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t3.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t3.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t4 = new Team("D");
            t4.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t4.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t4.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t4.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t4.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t4.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t4.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t4.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t4.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t4.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t4.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t4.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t4.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t4.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t4.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t4.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t4.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t4.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t4.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t4.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t4.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t4.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t4.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t4.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t5 = new Team("E");
            t5.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t5.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t5.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t5.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t5.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t5.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t5.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t5.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t5.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t5.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t5.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t5.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t5.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t5.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t5.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t5.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t5.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t5.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t5.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t5.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t5.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t5.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t5.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t5.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t6 = new Team("F");
            t6.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t6.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t6.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t6.AddPlayer(new Player(2, 10, 8, 5, "Danka"));
            t6.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t6.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t6.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t6.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t6.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t6.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t6.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t6.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t6.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t6.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t6.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t6.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t6.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t6.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t6.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t6.AddPlayer(new Player(8, 6, 2, 10, "Kiszke2"));
            t6.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t6.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t6.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t6.AddPlayer(new Player(5, 8, 8, 2, "Gosia2"));

            Team t7 = new Team("G");
           t7.AddPlayer(new Player(6, 2, 10, 7, "Marek"));
           t7.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
           t7.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
           t7.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
           t7.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
           t7.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
           t7.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
           t7.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
           t7.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
           t7.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
           t7.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
           t7.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
           t7.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
           t7.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
           t7.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
           t7.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
           t7.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
           t7.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
           t7.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
           t7.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
           t7.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
           t7.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
           t7.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
           t7.AddPlayer(new Player(5, 8, 8, 2, "Gosia2"));

            Team t8 = new Team("H");
           t8.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
           t8.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
           t8.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
           t8.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
           t8.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
           t8.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
           t8.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
           t8.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
           t8.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
           t8.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
           t8.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
           t8.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
           t8.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
           t8.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
           t8.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
           t8.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
           t8.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
           t8.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
           t8.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
           t8.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
           t8.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
           t8.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
           t8.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
           t8.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t9 = new Team("I");
            t9.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t9.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t9.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t9.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t9.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t9.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t9.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t9.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t9.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t9.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t9.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t9.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t9.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t9.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t9.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t9.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t9.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t9.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t9.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t9.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t9.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t9.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t9.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t9.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t10 = new Team("J");
            t10.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t10.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t10.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t10.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t10.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t10.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t10.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t10.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t10.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t10.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t10.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t10.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t10.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t10.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t10.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t10.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t10.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t10.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t10.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t10.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t10.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t10.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t10.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t10.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t11 = new Team("K");
           t11.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
           t11.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
           t11.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
           t11.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
           t11.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
           t11.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
           t11.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
           t11.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
           t11.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
           t11.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
           t11.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
           t11.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
           t11.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
           t11.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
           t11.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
           t11.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
           t11.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
           t11.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
           t11.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
           t11.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
           t11.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
           t11.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
           t11.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
           t11.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t12 = new Team("L");
            t12.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t12.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t12.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t12.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t12.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t12.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t12.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t12.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t12.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t12.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t12.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t12.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t12.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t12.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t12.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t12.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t12.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t12.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t12.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t12.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t12.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t12.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t12.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t12.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t13 = new Team("M");
            t13.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t13.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t13.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t13.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t13.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t13.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t13.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t13.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t13.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t13.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t13.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t13.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t13.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t13.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t13.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t13.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t13.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t13.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t13.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t13.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t13.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t13.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t13.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t13.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t14 = new Team("N");
            t14.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t14.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t14.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t14.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t14.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t14.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t14.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t14.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t14.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t14.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t14.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t14.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t14.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t14.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t14.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t14.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t14.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t14.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t14.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t14.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t14.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t14.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t14.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t14.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t15 = new Team("O");
            t15.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t15.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t15.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t15.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t15.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t15.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t15.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t15.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t15.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t15.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t15.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t15.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t15.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t15.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t15.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t15.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t15.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t15.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t15.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t15.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t15.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t15.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t15.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t15.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Team t16 = new Team("P");
            t16.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t16.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t16.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t16.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t16.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t16.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t16.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t16.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t16.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t16.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t16.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t16.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t16.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t16.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t16.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t16.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t16.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t16.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t16.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t16.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t16.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t16.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t16.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t16.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Game g = new Game(t1, t2, new LuckFactory(DateTime.Now.Millisecond));
            g.Run1();

            Game g1 = new Game(t3, t4, new LuckFactory(DateTime.Now.Millisecond));
            g1.Run1();

            Game g2 = new Game(t5, t6, new LuckFactory(DateTime.Now.Millisecond));
            g2.Run1();

            Game g3 = new Game(t7, t8, new LuckFactory(DateTime.Now.Millisecond));
            g3.Run1();

            Game g4 = new Game(t9, t10, new LuckFactory(DateTime.Now.Millisecond));
            g4.Run1();

            Game g5 = new Game(t11, t12, new LuckFactory(DateTime.Now.Millisecond));
            g5.Run1();

            Game g6 = new Game(t13, t14, new LuckFactory(DateTime.Now.Millisecond));
            g6.Run1();

            Game g7 = new Game(t15, t16, new LuckFactory(DateTime.Now.Millisecond));
            g7.Run1();

          

            Console.WriteLine($"Wygrala druzyna {g.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g.Losser.TeamName}");

            Console.WriteLine($"Wygrala druzyna {g1.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g1.Losser.TeamName}");

            Console.WriteLine($"Wygrala druzyna {g2.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g2.Losser.TeamName}");

            Console.WriteLine($"Wygrala druzyna {g3.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g3.Losser.TeamName}");

            Console.WriteLine($"Wygrala druzyna {g4.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g4.Losser.TeamName}");

            Console.WriteLine($"Wygrala druzyna {g5.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g5.Losser.TeamName}");

            Console.WriteLine($"Wygrala druzyna {g6.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g6.Losser.TeamName}");

            Console.WriteLine($"Wygrala druzyna {g7.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {g7.Losser.TeamName}");

            Console.ReadLine();
            Console.WriteLine("Nacisnij Enter,zeby zobaczyc PolFinal");
            Console.Clear();

            Game polFinal = new Game(g.Winner, g1.Winner, new LuckFactory(DateTime.Now.Millisecond));
            polFinal.Run1();

            Game polFinal1 = new Game(g2.Winner, g3.Winner, new LuckFactory(DateTime.Now.Millisecond));
            polFinal1.Run1();

            Game polFinal2 = new Game(g4.Winner, g5.Winner, new LuckFactory(DateTime.Now.Millisecond));
            polFinal2.Run1();

            Game polFinal3 = new Game(g6.Winner, g7.Winner, new LuckFactory(DateTime.Now.Millisecond));
            polFinal3.Run1();

            Console.WriteLine($"Wygrala druzyna {polFinal.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {polFinal.Losser.TeamName}");
            Console.WriteLine($"Wygrala druzyna {polFinal1.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {polFinal1.Losser.TeamName}");
            Console.WriteLine($"Wygrala druzyna {polFinal2.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {polFinal2.Losser.TeamName}");
            Console.WriteLine($"Wygrala druzyna {polFinal3.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {polFinal3.Losser.TeamName}");

            Console.ReadLine();
            Console.WriteLine("Nacisnij Enter,zeby zobaczyc Final");
            Console.Clear();

            Game Final = new Game(polFinal.Winner, polFinal1.Winner, new LuckFactory(DateTime.Now.Millisecond));
            Final.Run1();
            Game Final1 = new Game(polFinal2.Winner, polFinal3.Winner, new LuckFactory(DateTime.Now.Millisecond));
            Final1.Run1();

            Console.WriteLine($"Wygrala druzyna {Final.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {Final.Losser.TeamName}");
            Console.WriteLine($"Wygrala druzyna {Final1.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {Final1.Losser.TeamName}");

            Console.ReadLine();
            Console.WriteLine("Nacisnij Enter,zeby zobaczyc Final");
            Console.Clear();
            Game Koniec = new Game(Final.Winner, Final1.Winner, new LuckFactory(DateTime.Now.Millisecond));
            Koniec.Run1();
             Console.WriteLine($"Wygrala druzyna {Koniec.Winner.TeamName}");
            Console.WriteLine($"Przegrala druzyna  {Koniec.Losser.TeamName}");

            Console.ReadKey();
        }

    }
}
