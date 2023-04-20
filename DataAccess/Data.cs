using System.Collections.Generic;
using TemplateTask.Models;

namespace TemplateTask.DataAccess
{
    public static class Data
    {
        public static List<HomeFeatures> HomeFeatures = new List<HomeFeatures>
        {
            new HomeFeatures{Id = 1, Header="Lorem Ipsum", Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", Icon="bi bi-card-checklist" },
            new HomeFeatures{Id = 2, Header="Dolor Sitema", Body="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata", Icon="bi bi-bar-chart" },
            new HomeFeatures{Id = 3, Header="Sed ut perspiciatis", Body="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", Icon="bi bi-binoculars" }
        };

        public static List<ServiceFeatures> ServiceFeatures = new List<ServiceFeatures>
        {
            new ServiceFeatures{Id = 1, Header="Lorem Ipsum1", Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon="bx bxl-dribbble"},
            new ServiceFeatures{Id = 2, Header="Lorem Ipsum2", Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon="bx bx-file"},
            new ServiceFeatures{Id = 3, Header="Lorem Ipsum3", Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon="bx bx-tachometer"},
            new ServiceFeatures{Id = 4, Header="Lorem Ipsum4", Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon="bx bx-world"},
            new ServiceFeatures{Id = 5, Header="Lorem Ipsum5", Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon="bx bx-slideshow"},
            new ServiceFeatures{Id = 6, Header="Lorem Ipsum6", Body="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon="bx bx-arch"},

        };
    }
}
