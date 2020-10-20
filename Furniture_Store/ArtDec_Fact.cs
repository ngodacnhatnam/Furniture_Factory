using System;
namespace Furniture_Store {
    public class ArtDec_Fact : IFurniture {
        public IChair CreateChair(string segment) {
            return new Art_Deco_Chair();
        }
        public ITable CreateTable(string segment) {
            return new Art_Deco_Table();
        }
        public ISofa CreateSofa(string segment) {
            return new Art_Deco_Sofa();
        }
    }
}
