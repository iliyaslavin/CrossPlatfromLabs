using Xunit;
using Lab1; // ������ ����, � ����� ����������� ���� Program

namespace Lab1.Tests
{
    public class Lab1Tests
    {
        [Fact]
        public void Test_LosingPairs_FirstPair()
        {
            // ����������� ����� ��� ��� �����
            var expectedPair = (0, 0); // ��������� ����� ����

            // ��������� �����
            var result = Program.GetLosingPair(0);

            // ���������� ���������
            Assert.Equal(expectedPair, result);
        }

        [Fact]
        public void Test_LosingPairs_SecondPair()
        {
            // ������� ���� ����
            var expectedPair = (1, 1);
            var result = Program.GetLosingPair(1);
            Assert.Equal(expectedPair, result);
        }
    }
}
