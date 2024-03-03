using System;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_returnFalse()
        {
            var actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithBlankString_returnFalse()
        {
            var actual = Book.IsIsbn("   ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_returnFalse()
        {
            var actual = Book.IsIsbn("   ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_returnTrue()
        {
            var actual = Book.IsIsbn("Isbn 123-456-789 0");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_returnTrue()
        {
            var actual = Book.IsIsbn("Isbn 123-456-789 0123");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_returnFalse()
        {
            var actual = Book.IsIsbn("xxxx Isbn 123-456-789 0123");

            Assert.False(actual);
        }
    }
}
