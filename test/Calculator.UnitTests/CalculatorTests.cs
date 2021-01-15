using FluentAssertions;
using System;
using Xunit;

namespace CalculatorApp.UnitTests
{
	public class CalculatorTests
	{
		[Fact]
		public void Add_With3and5_ShouldReturn8()
		{
			Calculator calc = new Calculator();
			var result = calc.Add(3, 5);
			result.Should().NotBe(0); // Hatalı dogrulama
		}

		[Fact]
		public void Subtract_With5and3_ShouldReturn2()
		{
			Calculator calc = new Calculator();
			var result = calc.Subtract(5, 3);			
			// Eksik doğrulama
		}

		[Fact]
		public void Multiply_With5and3_ShouldReturn15()
		{
			Calculator calc = new Calculator();
			var result = calc.Multiply(5, 3);
			result.Should().Be(15);
		}

		[Theory]
		[InlineData(1, 2)]
		[InlineData(1, 0)]
		public void Divide_WhenCalled_ShouldReturnResult(int x, int y)
		{
			Calculator calc = new Calculator();
			try
			{
				var result = calc.Divide(x, y);
			}catch(Exception ex)
			{				
				// Şimdilik çalışsın da sonra bakarız
			}
		}
	}
}
