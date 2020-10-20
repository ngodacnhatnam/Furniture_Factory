using System;
using System.Collections.Generic;
namespace Furniture_Store {
    public class Clients {
        private IChair chair;
        private ITable table;
        private ISofa sofa;

        
    
        public Clients(IFurniture furniture, string segment) {
            chair = furniture.CreateChair(segment);
            table = furniture.CreateTable(segment);
            sofa = furniture.CreateSofa(segment);
        }
        public string GetChairName() {
            return chair.Name();
        }
        public string GetTableName() {
            return table.Name();
        }
        public string GetSofaName() {
            return sofa.Name();
        }
    }
}
