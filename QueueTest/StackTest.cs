using DataStructures;

namespace StackTest;

public class StackTest
{
    private Stack stack { get; set; } = null!;

    [SetUp]
    public void Setup()
    {
        stack = new Stack();
    }

    [Test]
    public void pushInitalNodeWhenStackIsEmpty()
    {
        // Assing
        int value = 5;

        // Act
        stack.Push(value);

        // Assert
        Assert.IsNotNull(stack.Top);
    }

    [Test]
    public void sizeShouldBeOneWhenAddingInitialValue()
    {
        int value = 5;

        stack.Push(value);

        Assert.That(stack.Size, Is.EqualTo(1));
    }

    [Test]
    public void sizeShouldBeTwoWhenAddingSecondValue()
    {
        int value = 5;

        stack.Push(value);
        stack.Push(value);

        Assert.That(stack.Size, Is.EqualTo(2));
    }

    [Test]
    public void sizeShouldBeThreeWhenAddingThirdValue()
    {
        int value = 5;

        stack.Push(value);
        stack.Push(value);
        stack.Push(value);

        Assert.That(stack.Size, Is.EqualTo(3));
    }

    [Test]
    public void popCheckStackIsEmpty()
    {
        stack.Pop();

        Assert.That(stack.Top, Is.EqualTo(null));
    }

    [Test]
    public void sizeShouldBeOneWhenRemovingValueFromPopMethod()
    {
        int value = 5;

        stack.Push(value);

        stack.Pop();

        Assert.IsNull(stack.Top);
    }

    [Test]
    public void sizeShouldBeTwoWhenRemovingValueFromPopMethod()
    {
        int value = 5;

        stack.Push(value);
        stack.Push(value);

        stack.Pop();

        Assert.IsNotNull(stack.Top);
    }

    [Test]
    public void sizeShouldBeThreeWhenRemovingValueFromPopMethod()
    {
        int value = 5;

        stack.Push(value);
        stack.Push(value);
        stack.Push(value);

        stack.Pop();

        Assert.IsNotNull(stack.Top);
    }

    [Test]
    public void stackShouldBeClearFromClearMethod()
    {
        int value = 5;

        stack.Push(value);
        stack.Push(value);
        stack.Push(value);

        stack.Clear();

        Assert.That(stack.Top, Is.Null);
    }

    [Test]
    public void stackSizeShouldBeClearFromClearMethod()
    {
        int value = 5;

        stack.Push(value);
        stack.Push(value);
        stack.Push(value);


        Assert.That(stack.Size, Is.EqualTo(3));

        stack.Clear();

        Assert.That(stack.Size, Is.EqualTo(0));
    }

    [Test]
    public void returnValueAtTheTopOfTheStackWithoutRemovingIt()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        stack.Peek();

        Assert.That(stack.Top.Value, Is.EqualTo(3));
    }

    [Test]
    public void usingACorrectValueToVerifyIsInStack()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        bool actual = stack.Contains(2);

        Assert.That(actual, Is.EqualTo(true));
    }

    [Test]
    public void usingAFakeValueToVerifyIsNotInStack()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        bool actual = stack.Contains(10);

        Assert.That(actual, Is.EqualTo(false));
    }

    [Test]
    public void convertingOneValueFromStackToArray()
    {
        stack.Push(1);

        int[] array = stack.ToArray();

        Assert.That(array, Has.Exactly(1).Items);
    }

    [Test]
    public void convertingTwoValuesFromStackToArray()
    {
        stack.Push(1);
        stack.Push(2);

        int[] array = stack.ToArray();

        Assert.That(array, Has.Exactly(2).Items);
    }

    [Test]
    public void convertingThreeValuesFromStackToArray()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        int[] array = stack.ToArray();

        Assert.That(array, Has.Exactly(3).Items);
    }

    [Test]
    public void verifyAllArrayValuesIsNotNull()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        int[] array = stack.ToArray();

        Assert.That(array, Is.All.Not.Null);
    }
}
