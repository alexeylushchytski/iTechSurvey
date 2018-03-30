using iTechart.Survey.DAL.Repositories;
using iTechArt.Repositories.Interfaces;

namespace iTechart.Survey.DAL.Interfaces
{
    public interface ISurveyUnitOfWork : IUnitOfWork
    {
        UsersRepository UsersRepository { get; set; }
    }
}