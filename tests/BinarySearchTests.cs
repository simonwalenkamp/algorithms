using algorithms;

namespace tests;

public class BinarySearchTests
{

    [Fact]
    public void Search_ElementInArray_ReturnsIndexOfElement()
    {
        BinarySearch searcher = new();

        int? result = searcher.Search([1, 2, 3, 4, 5], 3);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Search_ElementNotInArray_ReturnsNull()
    {
        BinarySearch searcher = new();

        int? result = searcher.Search([1, 2, 4, 5, 6], 3);

        Assert.Null(result);
    }
}
