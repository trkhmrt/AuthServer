using System;
namespace SharedLibrary.Dto
{
	public class ErrorDto
	{
		public List<String> Errors { get; private set; }

		public bool IsShow { get; private set; }

        public ErrorDto()
        {
			Errors = new List<string>();
        }

		public ErrorDto(string error,bool isShow)
		{
			Errors.Add(error);
			isShow = true;
		}


        public ErrorDto(List<string> error, bool isShow)
        {
			Errors = Errors;
			IsShow = isShow;
        }
    }

	
}

