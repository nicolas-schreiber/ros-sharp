/*
© Siemens AG, 2018-2019
Author: Berkay Alp Cakal (berkay_alp.cakal.ct@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;

using UnityEngine;
using System.IO;

namespace RosSharp.RosBridgeClient
{
    public class PointCloudWriter : MonoBehaviour
    {
        private bool isReceived = false;
        private RgbPoint3[] Points;
        private PointCloudVisualizer[] pointCloudVisualizers;

        private void Update()
        {
            pointCloudVisualizers = GetComponents<PointCloudVisualizer>();
            if (isReceived) {
                if (pointCloudVisualizers != null)
                    foreach (PointCloudVisualizer pointCloudVisualizer in pointCloudVisualizers)
                        pointCloudVisualizer.SetSensorData(gameObject.transform, Points);
            }

            isReceived = false;
        }

        public void Write(MessageTypes.Sensor.PointCloud2 message)
        {
            long I = message.data.Length / message.point_step;
            Points = new RgbPoint3[I];
            byte[] byteSlice = new byte[message.point_step];

            Debug.Log("Long   " + I);

            for (long i = 0; i < I; i++)
            {
                Array.Copy(message.data, i * message.point_step, byteSlice, 0, message.point_step);
                Points[i] = new RgbPoint3(byteSlice, message.fields);
            }

            isReceived = true;
        }

    }
}