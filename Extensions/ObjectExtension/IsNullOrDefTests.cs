using Template.Data.Persons;
// --
using Basic.Extensions.ObjectExtension;
// ----------------------------------------------------------------------------
namespace Basic.Tests.Extensions.ObjectExtension; 

public class IsNullOrDefTests {

  #region isNull
  [Fact]
  public void IsNullOrDef_ObjAmNull_True() {
    // arrange
    object obj = null;
    string str = null;
    int? num = null;
    DateTime? dt = null;
    IPerson person = null;

    // act
    bool actualObj = obj.IsNullOrDef<object>();
    bool actualStr = str.IsNullOrDef<string>();
    bool actualNum = num.IsNullOrDef<int?>();
    bool actualDt = dt.IsNullOrDef<DateTime?>();
    bool actualPerson = person.IsNullOrDef<IPerson>();

    // assert
    Assert.True(actualObj);
    Assert.True(actualStr);
    Assert.True(actualNum);
    Assert.True(actualDt);
    Assert.True(actualPerson);
  }

  [Fact]
  public void IsNullOrDef_ObjAmNotNull_False() {
    // arrange
    object obj = "";
    string str = "";
    int? num = 0;
    DateTime? dt = DateTime.Now;
    IPerson person = new Person();

    // act
    bool actualObj = obj.IsNullOrDef<object>();
    bool actualStr = str.IsNullOrDef<string>();
    bool actualNum = num.IsNullOrDef<int?>();
    bool actualDt = dt.IsNullOrDef<DateTime?>();
    bool actualPerson = person.IsNullOrDef<IPerson>();

    // assert
    Assert.False(actualObj);
    Assert.False(actualStr);
    Assert.False(actualNum);
    Assert.False(actualDt);
    Assert.False(actualPerson);
  }

  [Fact]
  public void AsNullOrDef_ObjAmNull_Obj() {
    // arrange
    object obj = null;
    string str = null;
    int? num = null;
    DateTime? dt = null;
    IPerson person = null;

    // act
    object actualObj = obj.AsNullOrDef<object>();
    string actualStr = str.AsNullOrDef<string>();
    int? actualNum = num.AsNullOrDef<int?>();
    DateTime? actualDt = dt.AsNullOrDef<DateTime?>();
    IPerson actualPerson = person.AsNullOrDef<IPerson>();

    // assert
    Assert.Null(actualObj);
    Assert.Null(actualStr);
    Assert.Null(actualNum);
    Assert.Null(actualDt);
    Assert.Null(actualPerson);
  }

  [Fact]
  public void AsNullOrDef_ObjAmNotNull_Ex() {
    // arrange
    object obj = "";
    string str = "";
    int? num = 0;
    DateTime? dt = DateTime.Now;
    IPerson person = new Person();

    // act

    // assert
    Assert.ThrowsAny<ArgumentException>(() => obj.AsNullOrDef<object>());
    Assert.ThrowsAny<ArgumentException>(() => str.AsNullOrDef<string>());
    Assert.ThrowsAny<ArgumentException>(() => num.AsNullOrDef<int?>());
    Assert.ThrowsAny<ArgumentException>(() => dt.AsNullOrDef<DateTime?>());
    Assert.ThrowsAny<ArgumentException>(() => person.AsNullOrDef<IPerson>());
  }

  [Fact]
  public void AsNotNullOrNotDef_ObjAmNotNull_Obj() {
    // arrange
    object expectedObj = "";
    string expectedStr = "";
    int? expectedNum = 0;
    DateTime? expectedDt = DateTime.Now;
    IPerson expectedPerson = new Person();

    // act
    object actualObj = expectedObj.AsNotNullOrNotDef<object>();
    string actualStr = expectedStr.AsNotNullOrNotDef<string>();
    int? actualNum = expectedNum.AsNotNullOrNotDef<int?>();
    DateTime? actualDt = expectedDt.AsNotNullOrNotDef<DateTime?>();
    IPerson actualPerson = expectedPerson.AsNotNullOrNotDef<IPerson>();

    // assert
    Assert.Equal(expectedObj,actualObj);
    Assert.Equal(expectedStr,actualStr);
    Assert.Equal(expectedNum,actualNum);
    Assert.Equal(expectedDt,actualDt);
    Assert.Equal(expectedPerson,actualPerson);
  }

  [Fact]
  public void AsNotNullOrNotDef_ObjAmNull_Ex() {
    // arrange
    object obj = null;
    string str = null;
    int? num = null;
    DateTime? dt = null;
    IPerson person = null;

    // act

    // assert
    Assert.ThrowsAny<ArgumentException>(() => obj.AsNotNullOrNotDef<object>());
    Assert.ThrowsAny<ArgumentException>(() => str.AsNotNullOrNotDef<string>());
    Assert.ThrowsAny<ArgumentException>(() => num.AsNotNullOrNotDef<int?>());
    Assert.ThrowsAny<ArgumentException>(() => dt.AsNotNullOrNotDef<DateTime?>());
    Assert.ThrowsAny<ArgumentException>(() => person.AsNotNullOrNotDef<IPerson>());
  }

  #endregion
  #region isDef
  [Fact]
  public void IsNullOrDef_ObjAmDef_True() {
    // arrange
    object expectedObj = default(object);
    string expectedStr = default(string);
    int expectedNum = default(int);
    DateTime expectedDt = default(DateTime);
    IPerson expectedPerson = default(Person);

    // act
    bool actualObj = expectedObj.IsNullOrDef();
    bool actuaStr = expectedStr.IsNullOrDef();
    bool actuaNum = expectedNum.IsNullOrDef();
    bool actuaDt = expectedDt.IsNullOrDef();
    bool actuaPerson = expectedPerson.IsNullOrDef();

    // assert
    Assert.True(actualObj);
    Assert.True(actuaStr);
    Assert.True(actuaNum);
    Assert.True(actuaDt);
    Assert.True(actuaPerson);
  }

  [Fact]
  public void IsNullOrDef_ObjAmNotDef_False() {
    // arrange
    object expectedObj = "";
    string expectedStr = "";
    int expectedNum = 1;
    DateTime expectedDt = DateTime.Now;
    IPerson expectedPerson = new Person();

    // act
    bool actualObj = expectedObj.IsNullOrDef();
    bool actuaStr = expectedStr.IsNullOrDef();
    bool actuaNum = expectedNum.IsNullOrDef();
    bool actuaDt = expectedDt.IsNullOrDef();
    bool actuaPerson = expectedPerson.IsNullOrDef();

    // assert
    Assert.False(actualObj);
    Assert.False(actuaStr);
    Assert.False(actuaNum);
    Assert.False(actuaDt);
    Assert.False(actuaPerson);
  }

  [Fact]
  public void AsNullOrDef_ObjAmDef_Obj() {
    object expectedObj = default(object);
    string expectedStr = default(string);
    int expectedNum = default(int);
    DateTime expectedDt = default(DateTime);
    IPerson expectedPerson = default(Person);

    // act
    object actualObj = expectedObj.AsNullOrDef();
    string actuaStr = expectedStr.AsNullOrDef();
    int actuaNum = expectedNum.AsNullOrDef();
    DateTime actuaDt = expectedDt.AsNullOrDef();
    IPerson actuaPerson = expectedPerson.AsNullOrDef();

    // assert
    Assert.Equal(expectedObj,actualObj);
    Assert.Equal(expectedStr,actuaStr);
    Assert.Equal(expectedNum,actuaNum);
    Assert.Equal(expectedDt,actuaDt);
    Assert.Equal(expectedPerson,actuaPerson);
  }

  [Fact]
  public void AsNullOrDef_ObjAmNotDef_Ex() {
    // arrange
    object obj = "";
    string str = "";
    int num = 1;
    DateTime dt = DateTime.Now;
    IPerson person = new Person();

    // act

    // assert
    Assert.Throws<ArgumentException>(() => obj.AsNullOrDef());
    Assert.Throws<ArgumentException>(() => str.AsNullOrDef());
    Assert.Throws<ArgumentException>(() => num.AsNullOrDef());
    Assert.Throws<ArgumentException>(() => dt.AsNullOrDef());
    Assert.Throws<ArgumentException>(() => person.AsNullOrDef());
  }

  [Fact]
  public void AsNotNullOrNotDef_ObjAmNotDef_Obj() {
    object expectedObj = "";
    string expectedStr = "";
    int expectedNum = 1;
    DateTime expectedDt = DateTime.Now;
    IPerson expectedPerson = new Person();

    // act
    object actualObj = expectedObj.AsNotNullOrNotDef();
    string actuaStr = expectedStr.AsNotNullOrNotDef();
    int actuaNum = expectedNum.AsNotNullOrNotDef();
    DateTime actuaDt = expectedDt.AsNotNullOrNotDef();
    IPerson actuaPerson = expectedPerson.AsNotNullOrNotDef();

    // assert
    Assert.Equal(expectedObj,actualObj);
    Assert.Equal(expectedStr,actuaStr);
    Assert.Equal(expectedNum,actuaNum);
    Assert.Equal(expectedDt,actuaDt);
    Assert.Equal(expectedPerson,actuaPerson);
  }

  [Fact]
  public void AsNotNullOrNotDef_ObjAmDef_Ex() {
    // arrange
    object obj = default(object);
    string str = default(string);
    int num = default(int);
    DateTime dt = default(DateTime);
    IPerson person = default(Person);

    // act

    // assert
    Assert.Throws<ArgumentException>(() => obj.AsNotNullOrNotDef());
    Assert.Throws<ArgumentException>(() => str.AsNotNullOrNotDef());
    Assert.Throws<ArgumentException>(() => num.AsNotNullOrNotDef());
    Assert.Throws<ArgumentException>(() => dt.AsNotNullOrNotDef());
    Assert.Throws<ArgumentException>(() => person.AsNotNullOrNotDef());
  }

  #endregion
}