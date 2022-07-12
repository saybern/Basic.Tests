using Template.Data.Persons;
// --
using Basic.Exceptions.Arguments;
using Basic.Extensions.ObjectExtension;
// ----------------------------------------------------------------------------
namespace Basic.Tests.Extensions.ObjectExtension;

public class IsNullTests {

  [Fact]
  public void IsNull_ObjAmNull_True() {
    // arrange
    object obj = null;
    string str = null;
    int? num = null;
    DateTime? dt = null;
    IPerson person = null;

    // act
    bool actualObj = obj.IsNull<object>();
    bool actualStr = str.IsNull<string>();
    bool actualNum = num.IsNull<int?>();
    bool actualDt = dt.IsNull<DateTime?>();
    bool actualPerson = person.IsNull<IPerson>();

    // assert
    Assert.True(actualObj);
    Assert.True(actualStr);
    Assert.True(actualNum);
    Assert.True(actualDt);
    Assert.True(actualPerson);
  }

  [Fact]
  public void IsNull_ObjAmNotNull_False() {
    // arrange
    object obj = "";
    string str = "";
    int? num = 0;
    DateTime? dt = DateTime.Now;
    IPerson person = new Person();

    // act
    bool actualObj = obj.IsNull<object>();
    bool actualStr = str.IsNull<string>();
    bool actualNum = num.IsNull<int?>();
    bool actualDt = dt.IsNull<DateTime?>();
    bool actualPerson = person.IsNull<IPerson>();

    // assert
    Assert.False(actualObj);
    Assert.False(actualStr);
    Assert.False(actualNum);
    Assert.False(actualDt);
    Assert.False(actualPerson);
  }

  [Fact]
  public void AsNull_ObjAmNull_Obj() {
    // arrange
    object obj = null;
    string str = null;
    int? num = null;
    DateTime? dt = null;
    IPerson person = null;

    // act
    object actualObj = obj.AsNull<object>();
    string actualStr = str.AsNull<string>();
    int? actualNum = num.AsNull<int?>();
    DateTime? actualDt = dt.AsNull<DateTime?>();
    IPerson actualPerson = person.AsNull<IPerson>();

    // assert
    Assert.Null(actualObj);
    Assert.Null(actualStr);
    Assert.Null(actualNum);
    Assert.Null(actualDt);
    Assert.Null(actualPerson);
  }

  [Fact]
  public void AsNull_ObjAmNotNull_Ex() {
    // arrange
    object obj = "";
    string str = "";
    int? num = 0;
    DateTime? dt = DateTime.Now;
    IPerson person = new Person();

    // act

    // assert
    Assert.Throws<ArgumentNotNullException>(() => obj.AsNull<object>());
    Assert.Throws<ArgumentNotNullException>(() => str.AsNull<string>());
    Assert.Throws<ArgumentNotNullException>(() => num.AsNull<int?>());
    Assert.Throws<ArgumentNotNullException>(() => dt.AsNull<DateTime?>());
    Assert.Throws<ArgumentNotNullException>(() => person.AsNull<IPerson>());
  }

  [Fact]
  public void AsNotNull_ObjAmNotNull_Obj() {
    // arrange
    object expectedObj = "";
    string expectedStr = "";
    int? expectedNum = 0;
    DateTime? expectedDt = DateTime.Now;
    IPerson expectedPerson = new Person();

    // act
    object actualObj = expectedObj.AsNotNull<object>();
    string actualStr = expectedStr.AsNotNull<string>();
    int? actualNum = expectedNum.AsNotNull<int?>();
    DateTime? actualDt = expectedDt.AsNotNull<DateTime?>();
    IPerson actualPerson = expectedPerson.AsNotNull<IPerson>();

    // assert
    Assert.Equal(expectedObj,actualObj);
    Assert.Equal(expectedStr,actualStr);
    Assert.Equal(expectedNum,actualNum);
    Assert.Equal(expectedDt,actualDt);
    Assert.Equal(expectedPerson,actualPerson);
  }

  [Fact]
  public void AsNotNull_ObjAmNull_Ex() {
    // arrange
    object obj = null;
    string str = null;
    int? num = null;
    DateTime? dt = null;
    IPerson person = null;

    // act

    // assert
    Assert.Throws<ArgumentNullException>(() => obj.AsNotNull<object>());
    Assert.Throws<ArgumentNullException>(() => str.AsNotNull<string>());
    Assert.Throws<ArgumentNullException>(() => num.AsNotNull<int?>());
    Assert.Throws<ArgumentNullException>(() => dt.AsNotNull<DateTime?>());
    Assert.Throws<ArgumentNullException>(() => person.AsNotNull<IPerson>());
  }
}