using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repoository_Interfface
{
    public abstract class IChannelDtlsRepo2 {
        int x;
        public void foo() { Console.WriteLine("AAABStract"); }
        public abstract void bar();
    }
    public interface IChannelDtlsRepo : IRepositoryBase<ChannelDtl> { }
    public class ChannelDtlsRepo : RepositoryBase<ChannelDtl>, IChannelDtlsRepo
    {
        public ChannelDtlsRepo(ChongaTvContext context) : base(context) { }
    }
    public interface ICountryRepo : IRepositoryBase<Country> { }
    public class CountryRepo : RepositoryBase<Country>, ICountryRepo
    {
        public CountryRepo(ChongaTvContext context) : base(context) { }
    }
    public interface ILanguageRepo : IRepositoryBase<ChannelDtl> { }
    public class LanguageRepo : RepositoryBase<ChannelDtl>, ILanguageRepo
    {
        public LanguageRepo(ChongaTvContext context) : base(context) { }
    }
    public interface IUsersInfoRepo : IRepositoryBase<ChannelDtl> { }
    public class UsersInfoRepo : RepositoryBase<ChannelDtl>, IUsersInfoRepo
    {
        public UsersInfoRepo(ChongaTvContext context) : base(context) { }
    }
}
