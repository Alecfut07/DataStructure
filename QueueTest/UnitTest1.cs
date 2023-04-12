using DataStructures;

namespace QueueTest;

public class Tests
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
        Assert.IsNotNull(queue.start);
    }

    [Test]
    public void enqueueAddsEndNodeWhenTheQueueIsEmpty()
    {
        int value = 5;

        queue.Enqueue(value);

        Assert.IsNotNull(queue.end);
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

        Assert.That(queue.start, Is.Not.EqualTo(queue.end));
    }

    [Test]
    public void DequeueCheckQueueIsEmpty()
    {
        queue.Dequeue();

        Assert.That(queue.start, Is.EqualTo(queue.end));
    }

    [Test]
    public void sizeShouldBeOneWhenRemovingValueFromDequeueMethod()
    {
        int value = 5;

        queue.Enqueue(value);

        queue.Dequeue();

        Assert.IsNull(queue.start);
    }

    [Test]
    public void sizeShouldBeTwoWhenRemovingValueFromDequeueMethod()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);

        queue.Dequeue();

        Assert.IsNotNull(queue.start);
    }

    [Test]
    public void sizeShouldBeThreeWhenRemovingValueFromDequeueMethod()
    {
        int value = 5;

        queue.Enqueue(value);
        queue.Enqueue(value);
        queue.Enqueue(value);

        queue.Dequeue();

        Assert.IsNotNull(queue.start);
    }
}
