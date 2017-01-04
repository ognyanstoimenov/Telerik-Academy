namespace Generic_Class
{
	using System;
	using System.Text;
	class GenericList<T> : IComparable
	{
		private T[] arr;
		private int length;

		public GenericList(int capacity)
		{
			this.Capacity = capacity;
			arr = new T[Capacity];
			Length = 0;
		}

		public int Capacity { get; private set; }
		public int Length { get { return length; } private set { length = value; } }

		public void Add(T element)
		{
			arr[Length] = element;
			Length++;
			if (Length >= Capacity)
			{
				DoubleSize();
			}
		}

		public T ElementAt(int index)
		{
			if (index > this.Length)
			{
				throw new IndexOutOfRangeException();
			}

			return arr[index];
		}

		public void RemoveAt(int index)
		{
			if (index > this.Length)
			{
				throw new IndexOutOfRangeException();
			}

			if (index < this.Length)
			{
				for (int i = index; i < this.Length; i++)
				{
					arr[i] = arr[i + 1];
				}
			}
			Length--;
		}

		public void AddAt(int index,T element)
		{
			if(index > this.Length)
			{
				throw new IndexOutOfRangeException();
			}

			for (int i = Length; i > index; i--)
			{
				this.arr[i] = this.arr[i - 1];
			}
			this.arr[index] = element;
			Length++;
			if (Length > Capacity)
			{
				DoubleSize();
			}
		}

		public void Clear()
		{
			this.arr = new T[Capacity];
			this.Length = 0;
		}

		public int IndexOf(T value)
		{
			for (int i = 0; i < Length; i++)
			{
				if(this.arr[i].Equals(value))
				{
					return i;
				}
			}
			return -1;
		}

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < this.Length - 1; i++)
			{
				result.Append(arr[i]);
				result.Append(',');
			}
			result.Append(arr[this.Length - 1]);
			return result.ToString();
		}

		public T Max()
		{
			T max = this.arr[0];
			for (int i = 1; i < this.Count; i++)
			{
				if (this.list[i].CompareTo(max) > 0)
				{
					max = this.arr[i];
				}
			}

			return max;
		}



		public T this[int index]
		{
			get { return arr[index]; }
			set { arr[index] = value; }
		}

		private void DoubleSize()
		{
			T[] newArr = new T[Capacity * 2];
			for (int i = 0; i < arr.Length; i++)
			{
				newArr[i] = arr[i];
			}
			arr = newArr;
		}
	}
}
