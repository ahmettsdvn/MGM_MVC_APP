using Common.LastStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    /// <summary>
    /// istasyona ait son durum bilgilerini tutam arayüz
    /// </summary>
    public interface ILastStatusInfo
    {
        /// <summary>
        /// verilen merkez ilçe koduna göre son durum bilgilerini getirir
        /// </summary>
        /// <param name="centerıd"></param>
        /// <returns></returns>
        LastStatusInfo GetLastStatusInfo(int centerıd);

    }
}
