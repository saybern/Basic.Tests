using Template.Data.Persons;
using Template.BusinessLogic.People;
// --
using Basic.Extensions.ObjectExtension;
// ----------------------------------------------------------------------------
namespace Basic.Tests.Extensions.ObjectExtension;

public class ValidTests {
  
  [Fact]
  public void IsValid_PersonAmValid_True() {
    // arrange
    IPerson person = new People().GetPeople()[0];

    // act
    bool actualPerson = person.IsValid();

    // assert
    Assert.True(actualPerson);
  }

  [Fact]
  public void IsValid_PersonAmNotValid_False() {
    // arrange
    IPerson person = new People().GetPeople()[0]
      .With(t => {
        t.Name = "";
        return t;
      });

    // act
    bool actualPerson = person.IsValid();

    // assert
    Assert.False(actualPerson);
  }

  [Fact]
  public void AsValid_PersonAmValid_Person() {
    // arrange
    IPerson person = new People().GetPeople()[0];

    // act
    IPerson actualPerson = person.AsValid();

    // assert
    Assert.Equal(person,actualPerson);
  }

  [Fact]
  public void AsValid_PersonAmNotValid_Ex() {
    // arrange
    IPerson person = new People().GetPeople()[0]
      .With(t => {
        t.Name = "";
        return t;
      });

    // act

    // assert
    Assert.Throws<ArgumentException>(() => person.AsValid());
  }
}