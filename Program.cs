using System;
using CSharpGrammer.printer;
using CSharpGrammer.input;

namespace CsharpGrammer
{
    class Program
    {
        enum ClassInfo
        {
            NONE = 0,
            KNIGHT = 1,
            ARCHER = 2,
            MAGE = 3
        }

        static void Main(string[] args)
        {
            while(true)
            {
                ClassInfo classinfo = SelectClassInfo();
                if (classinfo != ClassInfo.NONE)
                {
                    break;
                }
            }
            

            
        }

        static ClassInfo SelectClassInfo()
        {
            Printer.displayChoiceClassMsg();
            Printer.displayClassInfo();
            int selectKey = Input.SelectClass();

            switch (selectKey)
            {
                case (int)ClassInfo.KNIGHT:
                    return ClassInfo.KNIGHT;

                case (int)ClassInfo.ARCHER:
                    return ClassInfo.ARCHER;

                case (int)ClassInfo.MAGE:
                    return ClassInfo.MAGE;

                default:
                    return ClassInfo.NONE;
            }
        }
    }
}