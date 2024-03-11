using Newtonsoft.Json;

namespace ResourceConfigurator.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AdditionalCapabilities
    {
        [JsonProperty("ultraSSDEnabled")]
        public bool? UltraSSDEnabled;

        [JsonProperty("hibernationEnabled")]
        public bool? HibernationEnabled;
    }

    public class AdditionalUnattendContent
    {
        [JsonProperty("passName")]
        public string PassName;

        [JsonProperty("componentName")]
        public string ComponentName;

        [JsonProperty("settingName")]
        public string SettingName;

        [JsonProperty("content")]
        public string Content;
    }

    public class ApplicationGatewayBackendAddressPool
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class ApplicationProfile
    {
        [JsonProperty("galleryApplications")]
        public List<GalleryApplication> GalleryApplications;
    }

    public class ApplicationSecurityGroup
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class AvailabilitySet
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class AvailablePatchSummary
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("assessmentActivityId")]
        public string AssessmentActivityId;

        [JsonProperty("rebootPending")]
        public bool? RebootPending;

        [JsonProperty("criticalAndSecurityPatchCount")]
        public int? CriticalAndSecurityPatchCount;

        [JsonProperty("otherPatchCount")]
        public int? OtherPatchCount;

        [JsonProperty("startTime")]
        public DateTime? StartTime;

        [JsonProperty("lastModifiedTime")]
        public DateTime? LastModifiedTime;

        [JsonProperty("error")]
        public Error Error;
    }

    public class BillingProfile
    {
        [JsonProperty("maxPrice")]
        public int? MaxPrice;
    }

    public class BootDiagnostics
    {
        [JsonProperty("enabled")]
        public bool? Enabled;

        [JsonProperty("storageUri")]
        public string StorageUri;

        [JsonProperty("consoleScreenshotBlobUri")]
        public string ConsoleScreenshotBlobUri;

        [JsonProperty("serialConsoleLogBlobUri")]
        public string SerialConsoleLogBlobUri;

        [JsonProperty("status")]
        public Status Status;
    }

    public class CapacityReservation
    {
        [JsonProperty("capacityReservationGroup")]
        public CapacityReservationGroup CapacityReservationGroup;
    }

    public class CapacityReservationGroup
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class ConfigurationStatus
    {
        [JsonProperty("code")]
        public string Code;

        [JsonProperty("level")]
        public string Level;

        [JsonProperty("displayStatus")]
        public string DisplayStatus;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("time")]
        public DateTime? Time;
    }

    public class Detail
    {
        [JsonProperty("code")]
        public string Code;

        [JsonProperty("target")]
        public string Target;

        [JsonProperty("message")]
        public string Message;
    }

    public class DiagnosticsProfile
    {
        [JsonProperty("bootDiagnostics")]
        public BootDiagnostics BootDiagnostics;
    }

    public class DiffDiskSettings
    {
        [JsonProperty("option")]
        public string Option;

        [JsonProperty("placement")]
        public string Placement;
    }

    public class Disk
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("encryptionSettings")]
        public List<EncryptionSetting> EncryptionSettings;

        [JsonProperty("statuses")]
        public List<Status> Statuses;
    }

    public class DiskEncryptionKey
    {
        [JsonProperty("secretUrl")]
        public string SecretUrl;

        [JsonProperty("sourceVault")]
        public SourceVault SourceVault;
    }

    public class DiskEncryptionSet
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class DnsSettings
    {
        [JsonProperty("dnsServers")]
        public List<string> DnsServers;

        [JsonProperty("domainNameLabel")]
        public string DomainNameLabel;
    }

    public class DscpConfiguration
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class EncryptionSetting
    {
        [JsonProperty("diskEncryptionKey")]
        public DiskEncryptionKey DiskEncryptionKey;

        [JsonProperty("keyEncryptionKey")]
        public KeyEncryptionKey KeyEncryptionKey;

        [JsonProperty("enabled")]
        public bool? Enabled;
    }

    public class Error
    {
        [JsonProperty("details")]
        public List<Detail> Details;

        [JsonProperty("innererror")]
        public Innererror Innererror;

        [JsonProperty("code")]
        public string Code;

        [JsonProperty("target")]
        public string Target;

        [JsonProperty("message")]
        public string Message;
    }

    public class ExtendedLocation
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;
    }

    public class Extension
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("typeHandlerVersion")]
        public string TypeHandlerVersion;

        [JsonProperty("substatuses")]
        public List<Substatus> Substatuses;

        [JsonProperty("statuses")]
        public List<Status> Statuses;
    }

    public class ExtensionHandler
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("typeHandlerVersion")]
        public string TypeHandlerVersion;

        [JsonProperty("status")]
        public Status Status;
    }

    public class GalleryApplication
    {
        [JsonProperty("tags")]
        public string Tags;

        [JsonProperty("order")]
        public int? Order;

        [JsonProperty("packageReferenceId")]
        public string PackageReferenceId;

        [JsonProperty("configurationReference")]
        public string ConfigurationReference;
    }

    public class HardwareProfile
    {
        [JsonProperty("vmSize")]
        public string VmSize;

        [JsonProperty("vmSizeProperties")]
        public VmSizeProperties VmSizeProperties;
    }

    public class Host
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class HostGroup
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class Identity
    {
        [JsonProperty("principalId")]
        public string PrincipalId;

        [JsonProperty("tenantId")]
        public string TenantId;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("userAssignedIdentities")]
        public UserAssignedIdentities UserAssignedIdentities;
    }

    public class Image
    {
        [JsonProperty("uri")]
        public string Uri;
    }

    public class ImageReference
    {
        [JsonProperty("publisher")]
        public string Publisher;

        [JsonProperty("offer")]
        public string Offer;

        [JsonProperty("sku")]
        public string Sku;

        [JsonProperty("version")]
        public string Version;

        [JsonProperty("exactVersion")]
        public string ExactVersion;

        [JsonProperty("sharedGalleryImageId")]
        public string SharedGalleryImageId;

        [JsonProperty("communityGalleryImageId")]
        public string CommunityGalleryImageId;

        [JsonProperty("id")]
        public string Id;
    }

    public class Innererror
    {
        [JsonProperty("exceptiontype")]
        public string Exceptiontype;

        [JsonProperty("errordetail")]
        public string Errordetail;
    }

    public class InstanceView
    {
        [JsonProperty("platformUpdateDomain")]
        public int? PlatformUpdateDomain;

        [JsonProperty("platformFaultDomain")]
        public int? PlatformFaultDomain;

        [JsonProperty("computerName")]
        public string ComputerName;

        [JsonProperty("osName")]
        public string OsName;

        [JsonProperty("osVersion")]
        public string OsVersion;

        [JsonProperty("hyperVGeneration")]
        public string HyperVGeneration;

        [JsonProperty("rdpThumbPrint")]
        public string RdpThumbPrint;

        [JsonProperty("vmAgent")]
        public VmAgent VmAgent;

        [JsonProperty("maintenanceRedeployStatus")]
        public MaintenanceRedeployStatus MaintenanceRedeployStatus;

        [JsonProperty("disks")]
        public List<Disk> Disks;

        [JsonProperty("extensions")]
        public List<Extension> Extensions;

        [JsonProperty("vmHealth")]
        public VmHealth VmHealth;

        [JsonProperty("bootDiagnostics")]
        public BootDiagnostics BootDiagnostics;

        [JsonProperty("assignedHost")]
        public string AssignedHost;

        [JsonProperty("statuses")]
        public List<Status> Statuses;

        [JsonProperty("patchStatus")]
        public PatchStatus PatchStatus;

        [JsonProperty("isVMInStandbyPool")]
        public bool? IsVMInStandbyPool;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("typeHandlerVersion")]
        public string TypeHandlerVersion;

        [JsonProperty("substatuses")]
        public List<Substatus> Substatuses;
    }

    public class IpConfiguration
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("properties")]
        public Properties Properties;
    }

    public class IpTag
    {
        [JsonProperty("ipTagType")]
        public string IpTagType;

        [JsonProperty("tag")]
        public string Tag;
    }

    public class Key5688
    {
        [JsonProperty("principalId")]
        public string PrincipalId;

        [JsonProperty("clientId")]
        public string ClientId;
    }

    public class KeyEncryptionKey
    {
        [JsonProperty("keyUrl")]
        public string KeyUrl;

        [JsonProperty("sourceVault")]
        public SourceVault SourceVault;
    }

    public class LastPatchInstallationSummary
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("installationActivityId")]
        public string InstallationActivityId;

        [JsonProperty("maintenanceWindowExceeded")]
        public bool? MaintenanceWindowExceeded;

        [JsonProperty("notSelectedPatchCount")]
        public int? NotSelectedPatchCount;

        [JsonProperty("excludedPatchCount")]
        public int? ExcludedPatchCount;

        [JsonProperty("pendingPatchCount")]
        public int? PendingPatchCount;

        [JsonProperty("installedPatchCount")]
        public int? InstalledPatchCount;

        [JsonProperty("failedPatchCount")]
        public int? FailedPatchCount;

        [JsonProperty("startTime")]
        public DateTime? StartTime;

        [JsonProperty("lastModifiedTime")]
        public DateTime? LastModifiedTime;

        [JsonProperty("error")]
        public Error Error;
    }

    public class LinuxConfiguration
    {
        [JsonProperty("disablePasswordAuthentication")]
        public bool? DisablePasswordAuthentication;

        [JsonProperty("ssh")]
        public Ssh Ssh;

        [JsonProperty("provisionVMAgent")]
        public bool? ProvisionVMAgent;

        [JsonProperty("patchSettings")]
        public PatchSettings PatchSettings;
    }

    public class Listener
    {
        [JsonProperty("protocol")]
        public string Protocol;

        [JsonProperty("certificateUrl")]
        public string CertificateUrl;
    }

    public class LoadBalancerBackendAddressPool
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class MaintenanceRedeployStatus
    {
        [JsonProperty("isCustomerInitiatedMaintenanceAllowed")]
        public bool? IsCustomerInitiatedMaintenanceAllowed;

        [JsonProperty("preMaintenanceWindowStartTime")]
        public DateTime? PreMaintenanceWindowStartTime;

        [JsonProperty("preMaintenanceWindowEndTime")]
        public DateTime? PreMaintenanceWindowEndTime;

        [JsonProperty("maintenanceWindowStartTime")]
        public DateTime? MaintenanceWindowStartTime;

        [JsonProperty("maintenanceWindowEndTime")]
        public DateTime? MaintenanceWindowEndTime;

        [JsonProperty("lastOperationResultCode")]
        public string LastOperationResultCode;

        [JsonProperty("lastOperationMessage")]
        public string LastOperationMessage;
    }

    public class ManagedDisk
    {
        [JsonProperty("storageAccountType")]
        public string StorageAccountType;

        [JsonProperty("diskEncryptionSet")]
        public DiskEncryptionSet DiskEncryptionSet;

        [JsonProperty("securityProfile")]
        public SecurityProfile SecurityProfile;

        [JsonProperty("id")]
        public string Id;
    }

    public class NetworkInterface
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("properties")]
        public Properties Properties;
    }

    public class NetworkInterfaceConfiguration
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("properties")]
        public Properties Properties;
    }

    public class NetworkProfile
    {
        [JsonProperty("networkInterfaces")]
        public List<NetworkInterface> NetworkInterfaces;

        [JsonProperty("networkApiVersion")]
        public string NetworkApiVersion;

        [JsonProperty("networkInterfaceConfigurations")]
        public List<NetworkInterfaceConfiguration> NetworkInterfaceConfigurations;
    }

    public class NetworkSecurityGroup
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class OsDisk
    {
        [JsonProperty("osType")]
        public string OsType;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("createOption")]
        public string CreateOption;

        [JsonProperty("vhd")]
        public Vhd Vhd;

        [JsonProperty("caching")]
        public string Caching;

        [JsonProperty("diskSizeGB")]
        public int? DiskSizeGB;

        [JsonProperty("encryptionSettings")]
        public EncryptionSetting EncryptionSettings;

        [JsonProperty("image")]
        public Image Image;

        [JsonProperty("writeAcceleratorEnabled")]
        public bool? WriteAcceleratorEnabled;

        [JsonProperty("diffDiskSettings")]
        public DiffDiskSettings DiffDiskSettings;

        [JsonProperty("managedDisk")]
        public ManagedDisk ManagedDisk;

        [JsonProperty("deleteOption")]
        public string DeleteOption;
    }

    public class OsImageNotificationProfile
    {
        [JsonProperty("notBeforeTimeout")]
        public string NotBeforeTimeout;

        [JsonProperty("enable")]
        public bool? Enable;
    }

    public class OsProfile
    {
        [JsonProperty("computerName")]
        public string ComputerName;

        [JsonProperty("adminUsername")]
        public string AdminUsername;

        [JsonProperty("windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration;

        [JsonProperty("secrets")]
        public List<object> Secrets;

        [JsonProperty("allowExtensionOperations")]
        public bool? AllowExtensionOperations;

        [JsonProperty("customData")]
        public string CustomData;

        [JsonProperty("linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration;

        [JsonProperty("requireGuestProvisionSignal")]
        public bool? RequireGuestProvisionSignal;
    }

    public class PatchSettings
    {
        [JsonProperty("patchMode")]
        public string PatchMode;

        [JsonProperty("enableHotpatching")]
        public bool? EnableHotpatching;

        [JsonProperty("assessmentMode")]
        public string AssessmentMode;
    }

    public class PatchStatus
    {
        [JsonProperty("availablePatchSummary")]
        public AvailablePatchSummary AvailablePatchSummary;

        [JsonProperty("lastPatchInstallationSummary")]
        public LastPatchInstallationSummary LastPatchInstallationSummary;

        [JsonProperty("configurationStatuses")]
        public List<ConfigurationStatus> ConfigurationStatuses;
    }

    public class Plan
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("publisher")]
        public string Publisher;

        [JsonProperty("product")]
        public string Product;

        [JsonProperty("promotionCode")]
        public string PromotionCode;
    }

    public class Properties
    {
        [JsonProperty("vmId")]
        public string VmId;

        [JsonProperty("availabilitySet")]
        public AvailabilitySet AvailabilitySet;

        [JsonProperty("hardwareProfile")]
        public HardwareProfile HardwareProfile;

        [JsonProperty("storageProfile")]
        public StorageProfile StorageProfile;

        [JsonProperty("osProfile")]
        public OsProfile OsProfile;

        [JsonProperty("networkProfile")]
        public NetworkProfile NetworkProfile;

        [JsonProperty("provisioningState")]
        public string ProvisioningState;

        [JsonProperty("additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities;

        [JsonProperty("securityProfile")]
        public SecurityProfile SecurityProfile;

        [JsonProperty("diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile;

        [JsonProperty("virtualMachineScaleSet")]
        public VirtualMachineScaleSet VirtualMachineScaleSet;

        [JsonProperty("proximityPlacementGroup")]
        public ProximityPlacementGroup ProximityPlacementGroup;

        [JsonProperty("priority")]
        public string Priority;

        [JsonProperty("evictionPolicy")]
        public string EvictionPolicy;

        [JsonProperty("billingProfile")]
        public BillingProfile BillingProfile;

        [JsonProperty("host")]
        public Host Host;

        [JsonProperty("hostGroup")]
        public HostGroup HostGroup;

        [JsonProperty("licenseType")]
        public string LicenseType;

        [JsonProperty("extensionsTimeBudget")]
        public string ExtensionsTimeBudget;

        [JsonProperty("platformFaultDomain")]
        public int? PlatformFaultDomain;

        [JsonProperty("scheduledEventsProfile")]
        public ScheduledEventsProfile ScheduledEventsProfile;

        [JsonProperty("userData")]
        public string UserData;

        [JsonProperty("capacityReservation")]
        public CapacityReservation CapacityReservation;

        [JsonProperty("applicationProfile")]
        public ApplicationProfile ApplicationProfile;

        [JsonProperty("timeCreated")]
        public DateTime? TimeCreated;

        [JsonProperty("instanceView")]
        public InstanceView InstanceView;

        [JsonProperty("primary")]
        public bool? Primary;

        [JsonProperty("deleteOption")]
        public string DeleteOption;

        [JsonProperty("enableAcceleratedNetworking")]
        public bool? EnableAcceleratedNetworking;

        [JsonProperty("disableTcpStateTracking")]
        public bool? DisableTcpStateTracking;

        [JsonProperty("enableFpga")]
        public bool? EnableFpga;

        [JsonProperty("enableIPForwarding")]
        public bool? EnableIPForwarding;

        [JsonProperty("networkSecurityGroup")]
        public NetworkSecurityGroup NetworkSecurityGroup;

        [JsonProperty("dnsSettings")]
        public DnsSettings DnsSettings;

        [JsonProperty("ipConfigurations")]
        public List<IpConfiguration> IpConfigurations;

        [JsonProperty("dscpConfiguration")]
        public DscpConfiguration DscpConfiguration;

        [JsonProperty("subnet")]
        public Subnet Subnet;

        [JsonProperty("publicIPAddressConfiguration")]
        public PublicIPAddressConfiguration PublicIPAddressConfiguration;

        [JsonProperty("privateIPAddressVersion")]
        public string PrivateIPAddressVersion;

        [JsonProperty("applicationSecurityGroups")]
        public List<ApplicationSecurityGroup> ApplicationSecurityGroups;

        [JsonProperty("applicationGatewayBackendAddressPools")]
        public List<ApplicationGatewayBackendAddressPool> ApplicationGatewayBackendAddressPools;

        [JsonProperty("loadBalancerBackendAddressPools")]
        public List<LoadBalancerBackendAddressPool> LoadBalancerBackendAddressPools;

        [JsonProperty("idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes;

        [JsonProperty("ipTags")]
        public List<IpTag> IpTags;

        [JsonProperty("publicIPPrefix")]
        public PublicIPPrefix PublicIPPrefix;

        [JsonProperty("publicIPAddressVersion")]
        public string PublicIPAddressVersion;

        [JsonProperty("publicIPAllocationMethod")]
        public string PublicIPAllocationMethod;

        [JsonProperty("forceUpdateTag")]
        public string ForceUpdateTag;

        [JsonProperty("publisher")]
        public string Publisher;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("typeHandlerVersion")]
        public string TypeHandlerVersion;

        [JsonProperty("autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion;

        [JsonProperty("enableAutomaticUpgrade")]
        public bool? EnableAutomaticUpgrade;

        [JsonProperty("settings")]
        public Settings Settings;

        [JsonProperty("protectedSettings")]
        public ProtectedSettings ProtectedSettings;

        [JsonProperty("suppressFailures")]
        public bool? SuppressFailures;

        [JsonProperty("protectedSettingsFromKeyVault")]
        public ProtectedSettingsFromKeyVault ProtectedSettingsFromKeyVault;
    }

    public class ProtectedSettings
    {
    }

    public class ProtectedSettingsFromKeyVault
    {
        [JsonProperty("sourceVault")]
        public SourceVault SourceVault;

        [JsonProperty("secretUrl")]
        public string SecretUrl;
    }

    public class ProximityPlacementGroup
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class PublicIPAddressConfiguration
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("properties")]
        public Properties Properties;

        [JsonProperty("sku")]
        public Sku Sku;
    }

    public class PublicIPPrefix
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class PublicKey
    {
        [JsonProperty("path")]
        public string Path;

        [JsonProperty("keyData")]
        public string KeyData;
    }

    public class Resource
    {
        [JsonProperty("properties")]
        public Properties Properties;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("location")]
        public string Location;

        [JsonProperty("tags")]
        public Tags Tags;
    }

    public class Root
    {
        [JsonProperty("value")]
        public List<Value> Value;

        [JsonProperty("nextLink")]
        public string NextLink;
    }

    public class ScheduledEventsProfile
    {
        [JsonProperty("terminateNotificationProfile")]
        public TerminateNotificationProfile TerminateNotificationProfile;

        [JsonProperty("osImageNotificationProfile")]
        public OsImageNotificationProfile OsImageNotificationProfile;
    }

    public class SecurityProfile
    {
        [JsonProperty("securityEncryptionType")]
        public string SecurityEncryptionType;

        [JsonProperty("diskEncryptionSet")]
        public DiskEncryptionSet DiskEncryptionSet;

        [JsonProperty("uefiSettings")]
        public UefiSettings UefiSettings;

        [JsonProperty("encryptionAtHost")]
        public bool? EncryptionAtHost;

        [JsonProperty("securityType")]
        public string SecurityType;
    }

    public class Settings
    {
    }

    public class Sku
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("tier")]
        public string Tier;
    }

    public class SourceVault
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class Ssh
    {
        [JsonProperty("publicKeys")]
        public List<PublicKey> PublicKeys;
    }

    public class Status
    {
        [JsonProperty("code")]
        public string Code;

        [JsonProperty("level")]
        public string Level;

        [JsonProperty("displayStatus")]
        public string DisplayStatus;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("time")]
        public DateTime? Time;
    }

    public class Status2
    {
        [JsonProperty("code")]
        public string Code;

        [JsonProperty("level")]
        public string Level;

        [JsonProperty("displayStatus")]
        public string DisplayStatus;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("time")]
        public DateTime? Time;
    }

    public class StorageProfile
    {
        [JsonProperty("imageReference")]
        public ImageReference ImageReference;

        [JsonProperty("osDisk")]
        public OsDisk OsDisk;

        [JsonProperty("dataDisks")]
        public List<object> DataDisks;
    }

    public class Subnet
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class Substatus
    {
        [JsonProperty("code")]
        public string Code;

        [JsonProperty("level")]
        public string Level;

        [JsonProperty("displayStatus")]
        public string DisplayStatus;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("time")]
        public DateTime? Time;
    }

    public class Tags
    {
        [JsonProperty("key9428")]
        public string Key9428;
    }

    public class TerminateNotificationProfile
    {
        [JsonProperty("notBeforeTimeout")]
        public string NotBeforeTimeout;

        [JsonProperty("enable")]
        public bool? Enable;
    }

    public class UefiSettings
    {
        [JsonProperty("secureBootEnabled")]
        public bool? SecureBootEnabled;

        [JsonProperty("vTpmEnabled")]
        public bool? VTpmEnabled;
    }

    public class UserAssignedIdentities
    {
        [JsonProperty("key5688")]
        public Key5688 Key5688;
    }

    public class Value
    {
        [JsonProperty("properties")]
        public Properties Properties;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("location")]
        public string Location;

        [JsonProperty("tags")]
        public Tags Tags;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("plan")]
        public Plan Plan;

        [JsonProperty("resources")]
        public List<Resource> Resources;

        [JsonProperty("identity")]
        public Identity Identity;

        [JsonProperty("zones")]
        public List<string> Zones;

        [JsonProperty("extendedLocation")]
        public ExtendedLocation ExtendedLocation;
    }

    public class Vhd
    {
        [JsonProperty("uri")]
        public string Uri;
    }

    public class VirtualMachineScaleSet
    {
        [JsonProperty("id")]
        public string Id;
    }

    public class VmAgent
    {
        [JsonProperty("vmAgentVersion")]
        public string VmAgentVersion;

        [JsonProperty("extensionHandlers")]
        public List<ExtensionHandler> ExtensionHandlers;

        [JsonProperty("statuses")]
        public List<Status> Statuses;
    }

    public class VmHealth
    {
        [JsonProperty("status")]
        public Status Status;
    }

    public class VmSizeProperties
    {
        [JsonProperty("vCPUsAvailable")]
        public int? VCPUsAvailable;

        [JsonProperty("vCPUsPerCore")]
        public int? VCPUsPerCore;
    }

    public class WindowsConfiguration
    {
        [JsonProperty("provisionVMAgent")]
        public bool? ProvisionVMAgent;

        [JsonProperty("enableAutomaticUpdates")]
        public bool? EnableAutomaticUpdates;

        [JsonProperty("timeZone")]
        public string TimeZone;

        [JsonProperty("additionalUnattendContent")]
        public List<AdditionalUnattendContent> AdditionalUnattendContent;

        [JsonProperty("patchSettings")]
        public PatchSettings PatchSettings;

        [JsonProperty("winRM")]
        public WinRM WinRM;
    }

    public class WinRM
    {
        [JsonProperty("listeners")]
        public List<Listener> Listeners;
    }


}
