class E
{
	public E()
	{
		try
		{
			System.Web.HttpContext.Current.Response.Write("TESTTEST");
			System.Web.HttpContext.Current.Response.End();
		}
		catch{}
	}
}
