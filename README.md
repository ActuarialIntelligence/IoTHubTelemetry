# IoTHubTelemetry

author	ms.author	ms.service	ms.topic	ms.date
robinsh
robinsh
iot-hub
include
10/26/2018
The following table lists the limits associated with the different service tiers S1, S2, S3, and F1. For information about the cost of each unit in each tier, see Azure IoT Hub pricing.

Resource	S1 Standard	S2 Standard	S3 Standard	F1 Free
Messages/day	400,000	6,000,000	300,000,000	8,000
Maximum units	200	200	10	1
[!NOTE] If you anticipate using more than 200 units with an S1 or S2 tier hub or 10 units with an S3 tier hub, contact Microsoft Support.

The following table lists the limits that apply to IoT Hub resources.

Resource	Limit
Maximum paid IoT hubs per Azure subscription	50
Maximum free IoT hubs per Azure subscription	1
Maximum number of characters in a device ID	128
Maximum number of device identities
returned in a single call	1,000
IoT Hub message maximum retention for device-to-cloud messages	7 days
Maximum size of device-to-cloud message	256 KB
Maximum size of device-to-cloud batch	AMQP and HTTP: 256 KB for the entire batch 
MQTT: 256 KB for each message
Maximum messages in device-to-cloud batch	500
Maximum size of cloud-to-device message	64 KB
Maximum TTL for cloud-to-device messages	2 days
Maximum delivery count for cloud-to-device 
messages	100
Maximum delivery count for feedback messages 
in response to a cloud-to-device message	100
Maximum TTL for feedback messages in 
response to a cloud-to-device message	2 days
Maximum size of device twin 
(tags, reported properties, and desired properties)	8 KB
Maximum size of device twin string value	4 KB
Maximum depth of object in device twin	5
Maximum size of direct method payload	128 KB
Job history maximum retention	30 days
Maximum concurrent jobs	10 (for S3), 5 for (S2), 1 (for S1)
Maximum additional endpoints	10 (for S1, S2, and S3)
Maximum message routing rules	100 (for S1, S2, and S3)
Maximum number of concurrently connected device streams	50 (for S1, S2, S3, and F1 only)
Maximum device stream data transfer	300 MB per day (for S1, S2, S3, and F1 only)
[!NOTE] If you need more than 50 paid IoT hubs in an Azure subscription, contact Microsoft Support.

[!NOTE] Currently, the maximum number of devices you can connect to a single IoT hub is 1,000,000. If you want to increase this limit, contact Microsoft Support.

IoT Hub throttles requests when the following quotas are exceeded.

Throttle	Per-hub value
Identity registry operations 
(create, retrieve, list, update, and delete), 
individual or bulk import/export	83.33/sec/unit (5,000/min/unit) (for S3). 
1.67/sec/unit (100/min/unit) (for S1 and S2).
Device connections	6,000/sec/unit (for S3), 120/sec/unit (for S2), 12/sec/unit (for S1). 
Minimum of 100/sec.
Device-to-cloud sends	6,000/sec/unit (for S3), 120/sec/unit (for S2), 12/sec/unit (for S1). 
Minimum of 100/sec.
Cloud-to-device sends	83.33/sec/unit (5,000/min/unit) (for S3), 1.67/sec/unit (100/min/unit) (for S1 and S2).
Cloud-to-device receives	833.33/sec/unit (50,000/min/unit) (for S3), 16.67/sec/unit (1,000/min/unit) (for S1 and S2).
File upload operations	83.33 file upload notifications/sec/unit (5,000/min/unit) (for S3), 1.67 file upload notifications/sec/unit (100/min/unit) (for S1 and S2). 
10,000 SAS URIs can be out for an Azure Storage account at one time.
10 SAS URIs/device can be out at one time.
Direct methods	24 MB/sec/unit (for S3), 480 KB/sec/unit (for S2), 160 KB/sec/unit (for S1).
Based on 8-KB throttling meter size.
Device twin reads	500/sec/unit (for S3), Maximum of 100/sec or 10/sec/unit (for S2), 100/sec (for S1)
Device twin updates	250/sec/unit (for S3), Maximum of 50/sec or 5/sec/unit (for S2), 50/sec (for S1)
Jobs operations 
(create, update, list, and delete)	83.33/sec/unit (5,000/min/unit) (for S3), 1.67/sec/unit (100/min/unit) (for S2), 1.67/sec/unit (100/min/unit) (for S1).
Jobs per-device operation throughput	50/sec/unit (for S3), maximum of 10/sec or 1/sec/unit (for S2), 10/sec (for S1).
Device stream initiation rate	5 new streams/sec (for S1, S2, S3, and F1 only).