using System;
namespace Furniture_Store {
    public interface IFurniture {
        IChair CreateChair(string segment);
        ITable CreateTable(string segment);
        ISofa CreateSofa(string segment);
    }
}
