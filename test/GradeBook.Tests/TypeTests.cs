using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringActsLikeValue()
        {
            var x = "string";
            var uppered = MakeUpperCase(x);
            
            Assert.Equal("string", x);
            Assert.Equal("STRING", uppered);
        }

        private string MakeUpperCase(string x)
        {
            return x.ToUpper();
        }

        [Fact]
        public void ValueTypePassByRef()
        {
            var x = GetInt();
            SetIntByRef(out x);
            
            Assert.Equal(42, x);
        }

        private void SetIntByRef(out int i)
        {
            i = 42;
        }

        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);
            
            Assert.Equal(3, x);
        }

        private void SetInt(int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByRef(ref book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }       
        
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            
            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;
            
            Assert.Same(book1, book2);
        }

        private void GetBookSetNameByRef(ref InMemoryBook inMemoryBook, string newName)
        {
            inMemoryBook = new InMemoryBook(newName);
        }

        
        private void GetBookSetName(InMemoryBook inMemoryBook, string newName)
        {
            inMemoryBook = new InMemoryBook(newName);
        }

        private void SetName(InMemoryBook inMemoryBook, string newName)
        {
            inMemoryBook.Name = newName;
        }
        
        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}