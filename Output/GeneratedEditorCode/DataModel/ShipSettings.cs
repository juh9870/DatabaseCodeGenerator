//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System.Linq;
using EditorDatabase.Enums;
using EditorDatabase.Serializable;
using EditorDatabase.Model;

namespace EditorDatabase.DataModel
{
	public partial class ShipSettings
	{
		partial void OnDataDeserialized(ShipSettingsSerializable serializable, Database database);
		partial void OnDataSerialized(ref ShipSettingsSerializable serializable);


		public ShipSettings(ShipSettingsSerializable serializable, Database database)
		{
			DefaultWeightPerCell = new NumericValue<float>(serializable.DefaultWeightPerCell, 0.01f, 3.402823E+38f);
			MinimumWeightPerCell = new NumericValue<float>(serializable.MinimumWeightPerCell, 0.01f, 3.402823E+38f);
			BaseArmorPoints = new NumericValue<float>(serializable.BaseArmorPoints, -3.402823E+38f, 3.402823E+38f);
			ArmorPointsPerCell = new NumericValue<float>(serializable.ArmorPointsPerCell, -3.402823E+38f, 3.402823E+38f);
			ArmorRepairCooldown = new NumericValue<float>(serializable.ArmorRepairCooldown, 0f, 3.402823E+38f);
			BaseEnergyPoints = new NumericValue<float>(serializable.BaseEnergyPoints, -3.402823E+38f, 3.402823E+38f);
			BaseEnergyRechargeRate = new NumericValue<float>(serializable.BaseEnergyRechargeRate, -3.402823E+38f, 3.402823E+38f);
			EnergyRechargeCooldown = new NumericValue<float>(serializable.EnergyRechargeCooldown, 0f, 3.402823E+38f);
			BaseShieldRechargeRate = new NumericValue<float>(serializable.BaseShieldRechargeRate, -3.402823E+38f, 3.402823E+38f);
			ShieldRechargeCooldown = new NumericValue<float>(serializable.ShieldRechargeCooldown, 0f, 3.402823E+38f);
			BaseDroneReconstructionSpeed = new NumericValue<float>(serializable.BaseDroneReconstructionSpeed, 0f, 3.402823E+38f);
			MaxVelocity = new NumericValue<float>(serializable.MaxVelocity, 5f, 50f);
			MaxTurnRate = new NumericValue<float>(serializable.MaxTurnRate, 5f, 50f);

			OnDataDeserialized(serializable, database);
		}

		public void Save(ShipSettingsSerializable serializable)
		{
			serializable.DefaultWeightPerCell = DefaultWeightPerCell.Value;
			serializable.MinimumWeightPerCell = MinimumWeightPerCell.Value;
			serializable.BaseArmorPoints = BaseArmorPoints.Value;
			serializable.ArmorPointsPerCell = ArmorPointsPerCell.Value;
			serializable.ArmorRepairCooldown = ArmorRepairCooldown.Value;
			serializable.BaseEnergyPoints = BaseEnergyPoints.Value;
			serializable.BaseEnergyRechargeRate = BaseEnergyRechargeRate.Value;
			serializable.EnergyRechargeCooldown = EnergyRechargeCooldown.Value;
			serializable.BaseShieldRechargeRate = BaseShieldRechargeRate.Value;
			serializable.ShieldRechargeCooldown = ShieldRechargeCooldown.Value;
			serializable.BaseDroneReconstructionSpeed = BaseDroneReconstructionSpeed.Value;
			serializable.MaxVelocity = MaxVelocity.Value;
			serializable.MaxTurnRate = MaxTurnRate.Value;
			OnDataSerialized(ref serializable);
		}

		public NumericValue<float> DefaultWeightPerCell = new NumericValue<float>(0, 0.01f, 3.402823E+38f);
		public NumericValue<float> MinimumWeightPerCell = new NumericValue<float>(0, 0.01f, 3.402823E+38f);
		public NumericValue<float> BaseArmorPoints = new NumericValue<float>(0, -3.402823E+38f, 3.402823E+38f);
		public NumericValue<float> ArmorPointsPerCell = new NumericValue<float>(0, -3.402823E+38f, 3.402823E+38f);
		public NumericValue<float> ArmorRepairCooldown = new NumericValue<float>(0, 0f, 3.402823E+38f);
		public NumericValue<float> BaseEnergyPoints = new NumericValue<float>(0, -3.402823E+38f, 3.402823E+38f);
		public NumericValue<float> BaseEnergyRechargeRate = new NumericValue<float>(0, -3.402823E+38f, 3.402823E+38f);
		public NumericValue<float> EnergyRechargeCooldown = new NumericValue<float>(0, 0f, 3.402823E+38f);
		public NumericValue<float> BaseShieldRechargeRate = new NumericValue<float>(0, -3.402823E+38f, 3.402823E+38f);
		public NumericValue<float> ShieldRechargeCooldown = new NumericValue<float>(0, 0f, 3.402823E+38f);
		public NumericValue<float> BaseDroneReconstructionSpeed = new NumericValue<float>(0, 0f, 3.402823E+38f);
		public NumericValue<float> MaxVelocity = new NumericValue<float>(0, 5f, 50f);
		public NumericValue<float> MaxTurnRate = new NumericValue<float>(0, 5f, 50f);

		public static ShipSettings DefaultValue { get; private set; }
	}
}
