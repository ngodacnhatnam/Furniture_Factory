using System;
namespace Furniture_Store {
    // chair
    public class Art_Deco_Chair : IChair {
        public string Name() {
            return "Decoration Chair";
        }
    }
    public class Victorian_Chair : IChair {
        public string Name() {
            return "Victorian Style Chair";
        }
    }
    public class Modern_Chair : IChair {
        public string Name() {
            return "Modernize Chair";
        }
    }
    // table
    public class Art_Deco_Table : ITable {
        public string Name() {
            return "Decoration Table";
        }
    }
    public class Victorian_Table : ITable {
        public string Name() {
            return "Victorian Style Table";
        }
    }
    public class Modern_Table : ITable {
        public string Name() {
            return "Modernize Table";
        }
    }
    // sofa
    public class Art_Deco_Sofa : ISofa {
        public string Name() {
            return "Decoration Sofa";
        }
    }
    public class Victorian_Sofa : ISofa {
        public string Name() {
            return "Victorian Style Sofa";
        }
    }
    public class Modern_Sofa : ISofa {
        public string Name() {
            return "Modernize Sofa";
        }
    }
}
