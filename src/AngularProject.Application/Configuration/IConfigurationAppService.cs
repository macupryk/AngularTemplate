using System.Threading.Tasks;
using AngularProject.Configuration.Dto;

namespace AngularProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
