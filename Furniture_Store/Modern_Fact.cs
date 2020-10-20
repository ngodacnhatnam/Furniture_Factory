using System;
namespace Furniture_Store {
    public class Modern_Fact : IFurniture {
        public IChair CreateChair(string segment) {
            return new Modern_Chair();
        }
        public ITable CreateTable(string segment) {
            return new Modern_Table();
        }
        public ISofa CreateSofa(string segment) {
            return new Modern_Sofa();
        }
    }
}
