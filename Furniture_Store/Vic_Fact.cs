using System;
using System.Collections.Generic;
namespace Furniture_Store {
    public class Vic_Fact : IFurniture {
        public IChair CreateChair(string segment) {
            return new Victorian_Chair();
        }
        public ITable CreateTable(string segment) {
            return new Victorian_Table();
        }
        public ISofa CreateSofa(string segment) {
            return new Victorian_Sofa();
        }
    }
}
