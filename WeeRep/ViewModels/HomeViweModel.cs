using Core.Entities;
using Core.Entities.Apple;
using Core.Entities.Computer;
using Core.Entities.Huawei;
using Core.Entities.Motorola;
using Core.Entities.Nokia;
using Core.Entities.Oneplus;
using Core.Entities.Samsung;
using Core.Entities.Sony;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.Models;

namespace WeeRep.ViewModels
{
    public class HomeViweModel
    {
        public List<Xperia_X_Serien> Xperia_X_Serien { get; set; }
        public List<Xperia_Z_Serien> Xperia_Z_Serien { get; set; }
        public List<XperiaTopModeller> XperiaTopModeller { get; set; }

        public List<Images_Tabel> Images { get; set; }
       

        public List<AppleWatchReprationPreis> AppleWatchReprationPreis { get; set; }
        public List<IphoneReprationPreis> IphoneReprationPreis { get; set; }
        public List<MacbookReparation> MacbookReparation { get; set; }
        public List<IpadReprationPreis> IpadReprationPreis { get; set; }
        public List<ImacReparation> ImacReparation { get; set; }

        public List<Galaxy_A_Serien> Galaxy_A_Serien { get; internal set; }
        public List<Galaxy_S_Serien> Galaxy_S_Serien { get; internal set; }
        public List<GalaxyNoteSerien> GalaxyNoteSerien { get; internal set; }
        public List<Galaxy_J_Serien> Galaxy_J_Serien { get; internal set; }
        public List<Galaxy_Xcover_Serien> Galaxy_Xcover_Serien { get; internal set; }

        public List<Huawei_P_Serien> Huawei_P_Serien { get; internal set; }
        public List<Huawei_Mate_Serien> Huawei_Mate_Serien { get; internal set; }

        public List<NokiaRepartionPrice> NokiaRepartionPrice { get; internal set; }

        public List<OneplusReparation> OneplusReparation { get; internal set; }

        public List<Motorola_E_Serien> Motorola_E_Serien { get; internal set; }
        public List<Motorola_G_Serien> Motorola_G_Serien { get; internal set; }
        public List<MotorolaEdge_Serien> MotorolaEdge_Serien { get; internal set; }
        public List<MotorolaOne_Serien> MotorolaOne_Serien { get; internal set; }

        public List<CpmputerReparationPrice> CpmputerReparationPrice { get; internal set; }





    }
}
