using NUnit.Framework;
using System;
using System.IO;
namespace Tests
{
    [TestFixture]
    public class UnitTestsForLinkedList
    {
        [Test]
        public void LinkedListHelper_creates_linked_list()
        {
            //Test using the provided question
            Node linkedList = LinkedListHelpers.createLinkedList(
                new string[] { "E", "B", "E", "E", "B", "A", "B" });
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                LinkedListHelpers.print(linkedList);
                var result = sw.ToString().Trim();
                Assert.AreEqual(result, "E->B->E->E->B->A->B");
            }
        }
        [Test]
        public void LinkedListHelper_removes_duplicates_where_its_words()
        {
            Node linkedList = LinkedListHelpers.createLinkedList(
                new string[] { "BA", "BA", "BA", "BE", "BI", "BE", "BE" });
            Node filtered = LinkedListHelpers.removeDuplicate(linkedList);
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                LinkedListHelpers.print(filtered);
                var result = sw.ToString().Trim();
                Assert.AreEqual("BA->BA->BE->BI->BE", result);
            }
        }
        [Test]
        public void LinkedListHelper_maintains_list_where_no_duplicates()
        {
            //Test using the provided question
            Node linkedList = LinkedListHelpers.createLinkedList(
                new string[] { "BA", "BA", "BE", "BI", "BE", });
            Node filtered = LinkedListHelpers.removeDuplicate(linkedList);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                LinkedListHelpers.print(filtered);
                var result = sw.ToString().Trim();
                Assert.AreEqual("BA->BA->BE->BI->BE", result);
            }
        }
        [Test]
        public void LinkedListHelper_remove_duplicates_for_provided_test_case()
        {
            //Test using the provided question
            Node linkedList = LinkedListHelpers.createLinkedList(
                new string[] { "E", "B", "E", "E", "B", "A", "B" });
            Node filtered = LinkedListHelpers.removeDuplicate(linkedList);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                LinkedListHelpers.print(filtered);
                var result = sw.ToString().Trim();
                Assert.AreEqual("E->B->E->B->A", result);
            }
        }

        [TestCase("E")]
        [TestCase("A")]
        [TestCase("E")]
        public void Check_Node_class_creates_object_instance(string value)
        {
            Node node = new Node(value);
            Assert.AreEqual(node.data, value);
        }
        [Test]
        public void Linked_ListHelper_Filters_LinkedList_Correctly()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                linked_list.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual("E->B->E->B->A", result);
            }
        }


    }
}