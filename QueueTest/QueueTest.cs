using DataStructures;

namespace QueueTest;

public class QueueTest
{
    private Queue queue { get; set; } = null!;

    [SetUp]
    public void Setup()
    {
        queue = new Queue();
    }

    [Test]
    public void enqueueAddsInitalNodeWhenQueueIsEmpty()
    {
        // Assing
        int value = 5;

        // Act
        queue.Enqueue(value);

        // Assert
        Assert.IsNotNull(queue.Start);
    }

    [Test]
    public void enqueueAddsEndNodeWhenTheQueueIsEmpty()
    {
        int value = 5;

        queue.Enqueue(value);

        Assert.IsNotNull(queue.End);
    }

    [Test]
    public void sizeShouldBeOneWhenAddingInitialValue()
    {
        int value = 5;

        queue.Enqueue(value);

        Assert.That(queue.Size, Is.EqualTo(1));
    }

    [Test]
    public void sizeShouldBeTwoWhenAddingSecondValue()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);

        Assert.That(queue.Size, Is.EqualTo(2));
    }

    [Test]
    public void sizeShouldBeThreeWhenAddingThirdValue()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);
        queue.Enqueue(value);

        Assert.That(queue.Size, Is.EqualTo(3));
    }

    [Test]
    public void startNodeAndEndNodeShouldBeDifferent()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);

        Assert.That(queue.Start, Is.Not.EqualTo(queue.End));
    }

    [Test]
    public void DequeueCheckQueueIsEmpty()
    {
        queue.Dequeue();

        Assert.That(queue.Start, Is.EqualTo(queue.End));
    }

    [Test]
    public void sizeShouldBeOneWhenRemovingValueFromDequeueMethod()
    {
        int value = 5;

        queue.Enqueue(value);

        queue.Dequeue();

        Assert.IsNull(queue.Start);
    }

    [Test]
    public void sizeShouldBeTwoWhenRemovingValueFromDequeueMethod()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);

        queue.Dequeue();

        Assert.IsNotNull(queue.Start);
    }

    [Test]
    public void sizeShouldBeThreeWhenRemovingValueFromDequeueMethod()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);
        queue.Enqueue(value);

        queue.Dequeue();

        Assert.IsNotNull(queue.Start);
    }

    [Test]
    public void queueShouldBeClearFromClearMethod()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);
        queue.Enqueue(value);

        queue.Clear();

        Assert.That(queue.Start, Is.EqualTo(queue.End));
    }

    [Test]
    public void queueSizeShouldBeClearFromClearMethod()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);
        queue.Enqueue(value);


        Assert.That(queue.Size, Is.EqualTo(3));

        queue.Clear();

        Assert.That(queue.Size, Is.EqualTo(0));
    }

    [Test]
    public void returnValueAtTheBeginningOfTheQueueWithoutRemovingIt()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Peek();

        Assert.That(queue.Start.Value, Is.EqualTo(1));
    }

    [Test]
    public void usingACorrectValueToVerifyIsInQueue()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        bool actual = queue.Contains(2);

        Assert.That(actual, Is.EqualTo(true));
    }

    [Test]
    public void usingAFakeValueToVerifyIsNotInQueue()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        bool actual = queue.Contains(10);

        Assert.That(actual, Is.EqualTo(false));
    }

    [Test]
    public void convertingOneValueFromQueueToArray()
    {
        queue.Enqueue(1);

        int[] array = queue.ToArray();

        Assert.That(array, Has.Exactly(1).Items);
    }

    [Test]
    public void convertingTwoValuesFromQueueToArray()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);

        int[] array = queue.ToArray();

        Assert.That(array, Has.Exactly(2).Items);
    }

    [Test]
    public void convertingThreeValuesFromQueueToArray()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        int[] array = queue.ToArray();

        Assert.That(array, Has.Exactly(3).Items);
    }

    [Test]
    public void verifyAllArrayValuesIsNotNull()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        int[] array = queue.ToArray();

        Assert.That(array, Is.All.Not.Null);
    }
}
