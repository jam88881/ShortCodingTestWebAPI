using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShortCodingTestWebAPI.Controllers
{
    public class ListifyController : ApiController, IList<int>
    {
        public int Start = 100;
        public int End = 200;
        IEnumerable<int> oIEnumerable;

        // GET listify/listify
        public IEnumerable<string> Get()
        {
            var list = new ListifyController(100, 200);
            var val1 = list[50];
            var val2 = list[51];
            return new string[] { val1.ToString(), val2.ToString() };
        }

        // GET listify/listify/3/10/1
        public string Get(int start, int end, int index)
        {
            var list = new ListifyController(start, end);
            var val1 = list[index];
            return val1.ToString();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }

        public ListifyController()
        {
            oIEnumerable = Enumerable.Range(Start, End).Select(x => x);
        }

        public ListifyController(int pStart, int pEnd)
        {
            Start = pStart;
            End = pEnd;
            oIEnumerable = Enumerable.Range(Start, End).Select(x => x);
        }

        readonly IList<int> _list = new List<int>();

        public int this[int index] { get => oIEnumerable.ElementAt<int>(index); set => throw new NotImplementedException(); }

        public int Count => Math.Abs(End - Start);

        public bool IsReadOnly => false;

        public void Add(int item)
        {
            return;
        }

        public void Clear()
        {
            return;
        }

        public bool Contains(int item)
        {
            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            return;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return oIEnumerable.GetEnumerator();
        }

        public int IndexOf(int item)
        {
            return 0;
        }

        public void Insert(int index, int item)
        {
            return;
        }

        public bool Remove(int item)
        {
            return false;
        }

        public void RemoveAt(int index)
        {
            return;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return oIEnumerable.GetEnumerator();
        }
    }
}
