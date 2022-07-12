using Template.Data.Persons;
// --
using Basic.Extensions.ObjectExtension;
// ----------------------------------------------------------------------------
namespace Basic.Tests.Extensions.ObjectExtension;

public class IsDefTests {

  [Fact]
  public void IsDef_ObjAmDef_True() {
    // arrange
    object expectedObj = default(object);
    string expectedStr = default(string);
    int expectedNum = default(int);
    DateTime expectedDt = default(DateTime);
    IPerson expectedPerson = default(Person);

    // act
    bool actualObj = expectedObj.IsDef();
    bool actuaStr = expectedStr.IsDef();
    bool actuaNum = expectedNum.IsDef();
    bool actuaDt = expectedDt.IsDef();
    bool actuaPerson = expectedPerson.IsDef();

    // assert
    Assert.True(actualObj);
    Assert.True(actuaStr);
    Assert.True(actuaNum);
    Assert.True(actuaDt);
    Assert.True(actuaPerson);
  }

  [Fact]
  public void IsDef_ObjAmNotDef_False() {
    // arrange
    object expectedObj = "";
    string expectedStr = "";
    int expectedNum = 1;
    DateTime expectedDt = DateTime.Now;
    IPerson expectedPerson = new Person();

    // act
    bool actualObj = expectedObj.IsDef();
    bool actuaStr = expectedStr.IsDef();
    bool actuaNum = expectedNum.IsDef();
    bool actuaDt = expectedDt.IsDef();
    bool actuaPerson = expectedPerson.IsDef();

    // assert
    Assert.False(actualObj);
    Assert.False(actuaStr);
    Assert.False(actuaNum);
    Assert.False(actuaDt);
    Assert.False(actuaPerson);
  }

  [Fact]
  public void AsDef_ObjAmDef_Obj() {
    object expectedObj = default(object);
    string expectedStr = default(string);
    int expectedNum = default(int);
    DateTime expectedDt = default(DateTime);
    IPerson expectedPerson = default(Person);

    // act
    object actualObj = expectedObj.AsDef();
    string actuaStr = expectedStr.AsDef();
    int actuaNum = expectedNum.AsDef();
    DateTime actuaDt = expectedDt.AsDef();
    IPerson actuaPerson = expectedPerson.AsDef();

    // assert
    Assert.Equal(expectedObj,actualObj);
    Assert.Equal(expectedStr,actuaStr);
    Assert.Equal(expectedNum,actuaNum);
    Assert.Equal(expectedDt,actuaDt);
    Assert.Equal(expectedPerson,actuaPerson);
  }

  [Fact]
  public void AsDef_ObjAmNotDef_Ex() {
    // arrange
    object obj = "";
    string str = "";
    int num = 1;
    DateTime dt = DateTime.Now;
    IPerson person = new Person();

    // act

    // assert
    Assert.Throws<ArgumentException>(() => obj.AsDef());
    Assert.Throws<ArgumentException>(() => str.AsDef());
    Assert.Throws<ArgumentException>(() => num.AsDef());
    Assert.Throws<ArgumentException>(() => dt.AsDef());
    Assert.Throws<ArgumentException>(() => person.AsDef());
  }

  [Fact]
  public void AsNotDef_ObjAmNotDef_Obj() {
    object expectedObj = "";
    string expectedStr = "";
    int expectedNum = 1;
    DateTime expectedDt = DateTime.Now;
    IPerson expectedPerson = new Person();

    // act
    object actualObj = expectedObj.AsNotDef();
    string actuaStr = expectedStr.AsNotDef();
    int actuaNum = expectedNum.AsNotDef();
    DateTime actuaDt = expectedDt.AsNotDef();
    IPerson actuaPerson = expectedPerson.AsNotDef();

    // assert
    Assert.Equal(expectedObj,actualObj);
    Assert.Equal(expectedStr,actuaStr);
    Assert.Equal(expectedNum,actuaNum);
    Assert.Equal(expectedDt,actuaDt);
    Assert.Equal(expectedPerson,actuaPerson);
  }

  [Fact]
  public void AsNotDef_ObjAmDef_Ex() {
    // arrange
    object obj = default(object);
    string str = default(string);
    int num = default(int);
    DateTime dt = default(DateTime);
    IPerson person = default(Person);

    // act

    // assert
    Assert.Throws<ArgumentException>(() => obj.AsNotDef());
    Assert.Throws<ArgumentException>(() => str.AsNotDef());
    Assert.Throws<ArgumentException>(() => num.AsNotDef());
    Assert.Throws<ArgumentException>(() => dt.AsNotDef());
    Assert.Throws<ArgumentException>(() => person.AsNotDef());
  }
}