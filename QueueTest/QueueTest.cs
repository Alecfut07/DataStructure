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
    public void returnValueAtTheBeginningOfTheQueueWithoutRemovingIt()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Peek();

        Assert.That(queue.Start, Is.EqualTo(queue.End));
    }
}
