using DataStructures.Arrays.Neetcode;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DataStructures.Tests;

public class GroupAnagramsTests
{

    [Theory]
    [InlineData("eat", "tea", "tan", "ate", "nat", "bat")]

    public void GroupsAnagrams_BasicExample(params string[] words)
    {
        var groups = GroupAnagrams.IsGrouped(words);

        Assert.Equal(3, groups.Count);
        AssertGroupContains(groups, "eat", "tea", "ate");
        AssertGroupContains(groups, "tan", "nat");
        AssertGroupContains(groups, "bat");
    }

    [Theory]
    [InlineData(new object[]{new string[0] })]
    public void ReturnsEmptyForEmptyInput(string[] words)
    {
        var groups = GroupAnagrams.IsGrouped(words);
        Assert.Empty(groups);
    }

    [Theory]
    [InlineData("abc")]
    public void SingleWordReturnsSingleGroup(params string[] words)
    {
        var groups = GroupAnagrams.IsGrouped(words);

        Assert.Single(groups);
        Assert.Contains("abc", groups[0]);
    }

    private static void AssertGroupContains(IList<IList<string>> groups, params string[] expected)
    {
        bool found = groups.Any(g =>
            g.Count == expected.Length &&
            expected.All(e => g.Contains(e)));

        Assert.True(found, $"Expected group [{string.Join(", ", expected)}] not found in actual groups.");
    }
}