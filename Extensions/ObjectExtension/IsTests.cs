using Template.Data.Persons;
// --
using Basic.Extensions.ObjectExtension;
// ----------------------------------------------------------------------------
namespace Basic.Tests.Extensions.ObjectExtension; 

public class IsTests {

  [Fact]
  public void Is_ObjAmStrAndIntAndPerson_True() {
    // arrange
    object str = "";
    object num = 0;
    object person = new Person();

    // act
    bool actualStr = str.Is<string>();
    bool actualInt = num.Is<int>();
    bool actualPerson = person.Is<Person>();

    // assert
    Assert.True(actualStr);
    Assert.True(actualInt);
    Assert.True(actualPerson);
  }

  [Fact]
  public void Is_ObjAmNotStrAndNotIntNotEmployee_False() {
    // arrange
    object str = null;
    object num = "0";
    object person = new Person();

    // act
    bool actualStr = str.Is<string>();
    bool actualNum = num.Is<int>();
    bool actualPerson = person.Is<Employee>();

    // assert
    Assert.False(actualStr);
    Assert.False(actualNum);
    Assert.False(actualPerson);
  }

  [Fact]
  public void As_ObjAmStrAndIntAndPerson_Obj() {
    // arrange
    object expectedStr = "";
    object expectedNum = 0;
    object expectedPerson = new Person();

    // act
    object actualStr = expectedStr.As<string>();
    object actualNum = expectedNum.As<int>();
    object actualPerson = expectedPerson.As<Person>();

    // assert
    Assert.Equal(expectedStr,actualStr);
    Assert.Equal(expectedNum,actualNum);
    Assert.Equal(expectedPerson,actualPerson);
  }

  [Fact]
  public void As_ObjAmNotStrAndNotIntAndNotEmployee_Ex() {
    // arrange
    object str = null;
    object num = "0";
    object person = new Person();

    // act

    // assert
    Assert.Throws<ArgumentException>(() => str.As<string>());
    Assert.Throws<ArgumentException>(() => num.As<int>());
    Assert.Throws<ArgumentException>(() => person.As<Employee>());
  }
}