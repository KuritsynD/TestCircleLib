using System;
using CircleLib;
using Xunit;

namespace TestCircleLib;

public class GeometryTests
{
    private readonly Geometry _geometry;

    public GeometryTests()
    { 
        _geometry = new Geometry();
    }

    [Fact]
    public void CalculateCircleArea_ShouldReturnCorrectArea()
    {
        // Arrange
        double radius = 5;
        double expectedArea = Math.PI * radius * radius;

        // Act
        double actualArea = _geometry.CalculateCircleArea(radius);

        // Assert
        Assert.Equal(expectedArea, actualArea, precision: 5);
    }

    [Fact]
    public void CalculateCircleArea_ShouldThrowArgumentException_WhenRadiusIsNegative()
    {
        // Arrange
        double negativeRadius = -1;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _geometry.CalculateCircleArea(negativeRadius));
    }

    [Fact]
    public void CalculateTriangleArea_ShouldReturnCorrectArea()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        double expectedArea = 6;  // Площадь треугольника со сторонами 3, 4, 5 = 6

        // Act
        double actualArea = _geometry.CalculateTriangleArea(sideA, sideB, sideC);

        // Assert
        Assert.Equal(expectedArea, actualArea, precision: 5);
    }

    [Fact]
    public void CalculateTriangleArea_ShouldThrowArgumentException_WhenSidesAreInvalid()
    {
        // Arrange
        double sideA = 1;
        double sideB = 2;
        double sideC = 10;  // Невозможно построить треугольник с такими сторонами

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _geometry.CalculateTriangleArea(sideA, sideB, sideC));
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnTrue_ForRightTriangle()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;  // Это прямоугольный треугольник

        // Act
        bool isRight = _geometry.IsRightTriangle(sideA, sideB, sideC);

        // Assert
        Assert.True(isRight);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnFalse_ForNonRightTriangle()
    {
        // Arrange
        double sideA = 2;
        double sideB = 3;
        double sideC = 4;  // Это не прямоугольный треугольник

        // Act
        bool isRight = _geometry.IsRightTriangle(sideA, sideB, sideC);

        // Assert
        Assert.False(isRight);
    }

    [Fact]
    public void IsRightTriangle_ShouldThrowArgumentException_WhenSidesAreInvalid()
    {
        // Arrange
        double sideA = 1;
        double sideB = 2;
        double sideC = 10;  // Невозможно построить треугольник с такими сторонами

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _geometry.IsRightTriangle(sideA, sideB, sideC));
    }
}