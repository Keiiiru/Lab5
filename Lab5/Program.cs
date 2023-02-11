namespace ierarchy
{

    class SS
    {
        public SS(string pName, string pVersion)
        {
            Name = pName;
            Ver = pVersion;

        }
        public string Name;
        public string Ver;
        public virtual string Info
        { get { return Name + " : " + Ver; } }
        
    }
    class OS: SS
    {
        public OS(string pName,string pVersion, CoreType pCT)
            :base(pName,pVersion)
        {
            CT = pCT;   
        }
        public CoreType CT;
        public override string Info
        { get { return Name + " \n " + CT; } }
    }
    class App: SS
    {
        public App(string pName,string pVersion)
            :base(pName,pVersion)
        {

        }
    }
    class FreeOS : OS
    {
        public FreeOS(string pName, string pVersion, CoreType pCT)
            : base(pName, pVersion, pCT)
        {

        }
    }
    class PaidOS: OS
    {
        public PaidOS(string pName, string pVersion, CoreType pCT)
            :base(pName, pVersion, pCT)
        {

        }
    }

        
    

    public enum CoreType
    {
        Os_with_gybrid_core,
        OS_with_micro_core,
        Os_with_monolyth_core
    }
    class ierarchy
    {
        static void Main(string[] args)
        {
            SS[] mas = new SS[4];

            mas[0] = new OS("Windows", "11", CoreType.Os_with_gybrid_core);
            mas[1] = new App("Kaspersky", "6.11");
            mas[2] = new FreeOS("Linux Mint", "3.0", CoreType.Os_with_monolyth_core);
            mas[3] = new App("Dota2", "7.32b");
            


            for (int i = 0; i < 4;i++)  
            {
                Console.WriteLine(">>>>>>>>>>>>" + mas[i].GetType().Name);
                Console.WriteLine(mas[i].Info);
                Console.WriteLine("Версия: " + mas[i].Ver.ToString() + "\n");
                Console.WriteLine("\n");

                
            }
            Console.ReadKey();
        }
    }
    
}