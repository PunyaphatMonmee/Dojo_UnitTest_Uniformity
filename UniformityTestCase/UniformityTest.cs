using LibUniformity;

namespace UniformityTestCase
{
    public class UniformityTest
    {
        [Fact]
        public void ����ҳ������_852_���_��͡����ҳ_Uniformity_ź_1_�ѹ�֡�����()
        {
            //3A
            //Arrange
            int qtyAll = 855;
            int qtyUniformity = -1;
            bool expected = false;
            Uniformity uniformity = new Uniformity();

            //Act
            bool actual = uniformity.Isvaild(qtyAll, qtyUniformity);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}