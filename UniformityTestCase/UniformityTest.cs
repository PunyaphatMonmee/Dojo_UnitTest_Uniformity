using LibUniformity;

namespace UniformityTestCase
{
    public class UniformityTest
    {
        [Fact]
        public void ปริมาณทั้งหมด_852_ตัว_กรอกปริมาณ_Uniformity_ลบ_1_บันทึกไม่ได้()
        {
            //3A
            //Arrange
            int qtyAll = 852;
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