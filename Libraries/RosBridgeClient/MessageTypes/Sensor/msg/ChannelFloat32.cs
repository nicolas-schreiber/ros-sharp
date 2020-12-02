/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class ChannelFloat32 : Message
    {
        public override string RosMessageName => "sensor_msgs/ChannelFloat32";

        //  This message is used by the PointCloud message to hold optional data
        //  associated with each point in the cloud. The length of the values
        //  array should be the same as the length of the points array in the
        //  PointCloud, and each value should be associated with the corresponding
        //  point.
        //  Channel names in existing practice include:
        //    "u", "v" - row and column (respectively) in the left stereo image.
        //               This is opposite to usual conventions but remains for
        //               historical reasons. The newer PointCloud2 message has no
        //               such problem.
        //    "rgb" - For point clouds produced by color stereo cameras. uint8
        //            (R,G,B) values packed into the least significant 24 bits,
        //            in order.
        //    "intensity" - laser or pixel intensity.
        //    "distance"
        //  The channel name should give semantics of the channel (e.g.
        //  "intensity" instead of "value").
        public string name { get; set; }
        //  The values array should be 1-1 with the elements of the associated
        //  PointCloud.
        public float[] values { get; set; }

        public ChannelFloat32()
        {
            this.name = "";
            this.values = new float[0];
        }

        public ChannelFloat32(string name, float[] values)
        {
            this.name = name;
            this.values = values;
        }
    }
}
