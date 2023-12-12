using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbouiCOM.Framework;
namespace Common.Common
{
    class clsTable
    {
        Dictionary<string, string> keyvaltbl = new Dictionary<string, string>();

        public enum validval
        {
            none,
            yesno,
            ActiveInactive,
            dealertype,
            OutletOwnership,
            TransFrom,
            IsStockAdjustment,
            yesno_numeric,
            GRGI

        }
        public void FieldCreation()
        {



            #region "UDT"
            AddTables("REGIONS", "REGIONS", SAPbobsCOM.BoUTBTableType.bott_NoObject);
            AddTables("STOCKUP", "Stock Update", SAPbobsCOM.BoUTBTableType.bott_Document);
            AddFields("OWHS", "REGIONCODE", "REGIONCODE", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO
               , null, pairval(validval.none), SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, "REGIONS");
            AddTables("STOREBRAND", "StoreBrand", SAPbobsCOM.BoUTBTableType.bott_NoObject);
            AddFields("OWHS", "STORE_BRAND", "STORE_BRAND", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO
               , null, pairval(validval.none), SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, "STOREBRAND");

            #endregion


            #region "STOCKUP"
            AddFields("@STOCKUP", "WSDN", "WSDN", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);            
            AddFields("@STOCKUP", "DocNum", "Document Number", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);            
            AddFields("@STOCKUP", "DocEntry", "DocEntry", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);            
            AddFields("@STOCKUP", "Type", "Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.GRGI));
           
            #endregion,

            #region "BP Master"



            AddFields("OCRD", "POSSync", "POSSync", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OCRD", "POSReqId", "POSReqId", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OCRD", "Active", "Active", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.ActiveInactive));
            AddFields("OCRD", "IsFranchise", "Franchise", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno_numeric));
            AddFields("OCRD", "WarehouseCode", "WarehouseCode", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OCRD", "OutletOwnership", "OutletOwnership", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno_numeric));
            AddFields("OCRD", "CurrentKey", "CurrentKey", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OCRD", "IsWarehouse", "IsWarehouse", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OCRD", "DealerType", "DealerType", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.dealertype));
            #endregion,


            #region "Item Master"
            AddFields("OITM", "POSSync", "POSSync", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OITM", "POSReqId", "POSReqId", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OITM", "PriceList", "PriceList", SAPbobsCOM.BoFieldTypes.db_Alpha, 10);
            AddFields("OITM", "HSNCODE", "HSNCODE", SAPbobsCOM.BoFieldTypes.db_Alpha, 10);
            AddFields("OITM", "TaxRate", "TaxRate(%)", SAPbobsCOM.BoFieldTypes.db_Alpha, 10);
            AddFields("OITM", "CurrentKey", "CurrentKey", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OITM", "MaxLength4SerialNo", "MaxLength4SerialNo", SAPbobsCOM.BoFieldTypes.db_Alpha, 11);
            AddFields("OITM", "MinLength4SerialNo", "MinLength4SerialNo", SAPbobsCOM.BoFieldTypes.db_Alpha, 11);
            #endregion
            #region "Store Master"
            AddFields("OWHS", "EMAIL", "EMAIL", SAPbobsCOM.BoFieldTypes.db_Alpha, 20);
            AddFields("OWHS", "OUTLETOWNERSHIP", "OutletOwnership", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.OutletOwnership));
            AddFields("OWHS", "DEALERTYPE", "DealerType", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.dealertype));
            AddFields("OWHS", "GSTNUMBER", "GstNumber", SAPbobsCOM.BoFieldTypes.db_Alpha, 16);
            AddFields("OWHS", "CHARGETAXFORFREEPRODUCTS", "ChargeTaxforFreeProducts", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OWHS", "ISWAREHOUSE", "ISWAREHOUSE", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno_numeric));
            AddFields("OWHS", "POSSync", "POSSync", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OWHS", "POSReqId", "POSReqId", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OWHS", "WAREHOUSECODE", "WarehouseCode", SAPbobsCOM.BoFieldTypes.db_Alpha, 10);
            AddFields("OWHS", "ITWHS", "Intransit WarehouseCode", SAPbobsCOM.BoFieldTypes.db_Alpha, 15);
            AddFields("OWHS", "IsITWHS", "Is Intransit Warehouse", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OWHS", "CurrentKey", "CurrentKey", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            #endregion,

            #region "Employee Master"

            AddFields("OHEM", "POSSync", "POSSync", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OHEM", "POSReqId", "POSReqId", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OHEM", "CurrentKey", "CurrentKey", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            #endregion,
            #region "StoreBrand Master"
            AddFields("OITB", "POSSync", "POSSync", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OITB", "POSReqId", "POSReqId", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OITB", "IsActive", "IsActive", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.ActiveInactive));
            AddFields("OITB", "CurrentKey", "CurrentKey", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            #endregion,
            #region "Pricelist Master"
            AddFields("ITM1", "POSSync", "POSSync", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("ITM1", "POSReqId", "POSReqId", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            #endregion,
            #region "Accountheader Master"

            AddFields("OACT", "POSSync", "POSSync", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.yesno));
            AddFields("OACT", "POSReqId", "POSReqId", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OACT", "CurrentKey", "CurrentKey", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            #endregion,

            #region "Transaction udf"
            AddFields("OINV", "WSDN", "WSDN", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            AddFields("OINV", "UserName", "UserName", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "ERP");
            AddFields("OINV", "ROD", "ROD", SAPbobsCOM.BoFieldTypes.db_Alpha, 10);
            AddFields("OINV", "From", "From", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.TransFrom));
            AddFields("OINV", "IsStockAdjustment", "Is Stock Adjustment", SAPbobsCOM.BoFieldTypes.db_Alpha, 10, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO, "", pairval(validval.IsStockAdjustment));


            AddFields("INV1", "MRP", "MRP", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            #endregion,
            #region "PAYMENTS udf"
            AddFields("ORCT", "WSDN", "WSDN", SAPbobsCOM.BoFieldTypes.db_Alpha, 50);
            #endregion,

            AddUDO("Stock Update", "Stock Update", SAPbobsCOM.BoUDOObjType.boud_Document, "STOCKUP", new[] { ""},new[] { "DocEntry", "U_WSDN", "U_Type", "U_DocNum" }, true, false);

              SPCreate();
        }

        private void SPCreate()
        {

            string procedure = @"
                    /* IN HANA STUDIO RUN THIS QUERY*/

                    ALTER PROCEDURE SBO_SP_TransactionNotification
                    (
                    in object_type nvarchar(30), 
                    in transaction_type nchar(1),
                    in num_of_cols_in_key int,
                    in list_of_key_cols_tab_del nvarchar(255),
                    in list_of_cols_val_tab_del nvarchar(255)
                    )
                    LANGUAGE SQLSCRIPT
                    AS
                    error int;
                    error_message nvarchar (200);
                    posreqid nvarchar(200);
                    curreqid nvarchar(200);
                    POSSync nvarchar(200);
                    CurrDoc nvarchar(200);
                    CurrValue nvarchar(200);
                    RIType nvarchar(200);
                    begin
                    error := 0;
                    error_message := N'Ok';
 
                    if(:transaction_type='U' and :object_type='4') then
                    select ""U_CurrentKey"" INTO curreqid from oitm where ""ItemCode""=:list_of_cols_val_tab_del;
                    select ""U_POSReqId"" INTO posreqid from oitm where ""ItemCode"" =:list_of_cols_val_tab_del;
                    select ""U_POSSync"" INTO POSSync from oitm where ""ItemCode"" =:list_of_cols_val_tab_del;
                    if (:posreqid = :curreqid  ) then
                        update oitm set ""U_POSReqId"" = '',""U_POSSync"" = 'N' where ""ItemCode"" =:list_of_cols_val_tab_del;
                    else
                    update oitm set ""U_CurrentKey"" = ""U_POSReqId"" where ""ItemCode"" =:list_of_cols_val_tab_del;
                    End if;
                    End if ;

                    if (:transaction_type = 'U' and: object_type = '64') then
                            select ""U_CurrentKey"" INTO curreqid from owhs where ""WhsCode"" =:list_of_cols_val_tab_del;
                    select ""U_POSReqId"" INTO posreqid from owhs where ""WhsCode"" =:list_of_cols_val_tab_del;
                    if (:posreqid = :curreqid) then
                        update owhs set ""U_POSReqId"" = '',""U_POSSync"" = 'N' where ""WhsCode"" =:list_of_cols_val_tab_del;
                    else
                    update owhs set ""U_CurrentKey"" = ""U_POSReqId"" where ""WhsCode"" =:list_of_cols_val_tab_del;
                    End if;
                    End if ;

                    if (:transaction_type = 'U' and: object_type = '171') then
                            select ""U_CurrentKey"" INTO curreqid from ohem where ""empID"" =:list_of_cols_val_tab_del;
                    select ""U_POSReqId"" INTO posreqid from ohem where ""empID"" =:list_of_cols_val_tab_del;
                    if (:posreqid = :curreqid) then
                        update ohem set ""U_POSReqId"" = '' ,""U_POSSync"" = 'N' where ""empID"" =:list_of_cols_val_tab_del;
                    else
                    update ohem set ""U_CurrentKey"" = ""U_POSReqId"" where ""empID"" =:list_of_cols_val_tab_del;
                    End if;
                    End if ;

                    if (:transaction_type = 'U' and: object_type = '1') then
                            select ""U_CurrentKey"" INTO curreqid from oact where ""AcctCode"" =:list_of_cols_val_tab_del;
                    select ""U_POSReqId"" INTO posreqid from oact where ""AcctCode"" =:list_of_cols_val_tab_del;
                    if (:posreqid = :curreqid) then
                        update oact set ""U_POSReqId"" = '',""U_POSSync"" = 'N' where ""AcctCode"" =:list_of_cols_val_tab_del;
                    else
                    update oact set ""U_CurrentKey"" = ""U_POSReqId"" where ""AcctCode"" =:list_of_cols_val_tab_del;
                    End if;
                    End if ;


                    if (:transaction_type = 'U' and: object_type = '52') then
                            select ""U_CurrentKey"" INTO curreqid from oitb where ""ItmsGrpCod"" =:list_of_cols_val_tab_del;
                    select ""U_POSReqId"" INTO posreqid from oitb where ""ItmsGrpCod"" =:list_of_cols_val_tab_del;
                    if (:posreqid = :curreqid) then
                        update oitb set ""U_POSReqId"" = '',""U_POSSync"" = 'N' where ""ItmsGrpCod"" =:list_of_cols_val_tab_del;
                    else
                    update oitb set ""U_CurrentKey"" = ""U_POSReqId"" where ""ItmsGrpCod"" =:list_of_cols_val_tab_del;
                    End if;
                    End if ;

                    if (:transaction_type = 'U' and: object_type = '2') then
                            select ""U_CurrentKey"" INTO curreqid from OCRD where ""CardCode"" =:list_of_cols_val_tab_del;
                    select ""U_POSReqId"" INTO posreqid from OCRD where ""CardCode"" =:list_of_cols_val_tab_del;
                    if (:posreqid = :curreqid) then
                        update OCRD set ""U_POSReqId"" = '',""U_POSSync"" = 'N' where ""CardCode"" =:list_of_cols_val_tab_del;
                    else
                    update OCRD set ""U_CurrentKey"" = ""U_POSReqId"" where ""CardCode"" =:list_of_cols_val_tab_del;
                    End if;
                    End if ;

                    if (:transaction_type = 'A' and: object_type = '13') then
                            update oinv set ""U_WSDN"" = '' where ""DocEntry"" =:list_of_cols_val_tab_del;
                    End if ;

                    if (:transaction_type = 'A' and: object_type = '67') then
                            update oinv set ""U_WSDN"" = '' where ""DocEntry"" =:list_of_cols_val_tab_del;
                    End if ;
                    if (:transaction_type = 'A' and: object_type = 'Stock Update') then
                            select ""U_DocEntry"" INTO CurrDoc from ""@STOCKUP""
                    where ""DocEntry"" =:list_of_cols_val_tab_del;
                    select ""U_WSDN"" INTO CurrValue from ""@STOCKUP""
                    where ""DocEntry"" =:list_of_cols_val_tab_del;
                    select ""U_Type"" INTO RIType from ""@STOCKUP""
                    where ""DocEntry"" =:list_of_cols_val_tab_del;
                    if (:RIType = 1) then
                    if (:Currdoc <> '' AND: CurrValue <> '' ) THEN
                    UPDATE OIGN SET ""U_WSDN"" =:CurrValue WHERE ""DocEntry"" =:Currdoc;
                    END if;
                    else
                    if (:Currdoc <> '' AND: CurrValue <> '' ) THEN
                        UPDATE OIGE SET ""U_WSDN"" =:CurrValue WHERE ""DocEntry"" =:Currdoc;
                    END if;
                    EnD if;
                    /* error=1;
                    error_message  =  :CurrDoc || :currvalue ||:list_of_cols_val_tab_del || list_of_key_cols_tab_del; */
                    END if;

                    select: error, :error_message FROM dummy;
                    END;
                    ";


            string procedureVariable = procedure;


            return;

        }

        private void pricelistquery()
        {
            //            {
            //                "SqlCode":"OB_PriceListsPara",
            //    "SqlName":"QueryonPriceList",
            //    "SqlText":"SELECT T2.ListNum  AS PriceListID,T2.ListName AS PriceListName,T1.ItemCode AS ProductCode,T1.Price AS Rate,T2.ValidFor AS Active FROM OITM  T0 left JOIN ITM1 T1 ON T0.ItemCode = T1.ItemCode left JOIN OPLN T2 ON T1.PriceList = T2.ListNum WHERE T1.Price <> '0' and T1.U_POSReqId=:U_POSReqId"
            //}

            //{
                //                "SqlCode":"OB_PriceLists",
                //    "SqlName":"QueryonPriceList",
                //    "SqlText":"SELECT T2.ListNum  AS PriceListID,T2.ListName AS PriceListName,T1.ItemCode AS ProductCode,T1.Price AS Rate,T2.ValidFor AS Active FROM OITM  T0 left JOIN ITM1 T1 ON T0.ItemCode = T1.ItemCode left JOIN OPLN T2 ON T1.PriceList = T2.ListNum WHERE T1.Price <> '0' "
                //}
            //}

        }  
        #region Table Creation Common Functions
            private void AddTables(string strTab, string strDesc, SAPbobsCOM.BoUTBTableType nType)
        {
            // var oUserTablesMD = default(SAPbobsCOM.UserTablesMD);
            SAPbobsCOM.UserTablesMD oUserTablesMD = null;
            try
            {
                oUserTablesMD = (SAPbobsCOM.UserTablesMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables);
                // Adding Table
                if (!oUserTablesMD.GetByKey(strTab))
                {
                    oUserTablesMD.TableName = strTab;
                    oUserTablesMD.TableDescription = strDesc;
                    oUserTablesMD.TableType = nType;

                    if (oUserTablesMD.Add() != 0)
                    {
                        throw new Exception(clsModule.objaddon.objcompany.GetLastErrorDescription() + strTab);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserTablesMD);
                oUserTablesMD = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }
        private Dictionary<string, string> pairval(validval Yesno)
        {
            keyvaltbl.Clear();
            switch (Yesno)
            {
                case validval.yesno:
                    keyvaltbl.Add("Y", "Yes");
                    keyvaltbl.Add("N", "No");
                    break;
                case validval.yesno_numeric:
                    keyvaltbl.Add("1", "Yes");
                    keyvaltbl.Add("0", "No");
                    break;
                case validval.ActiveInactive:
                    keyvaltbl.Add("0", "InActive");
                    keyvaltbl.Add("1", "Active");
                    break;
                case validval.dealertype:
                    keyvaltbl.Add("0", "None");
                    keyvaltbl.Add("1", "GST");
                    keyvaltbl.Add("2", "TurnOverBased");
                    keyvaltbl.Add("3", "Non GST");
                    break;
                case validval.OutletOwnership:
                    keyvaltbl.Add("0", "Company Outlet");
                    keyvaltbl.Add("1", "Non-Company Outlet");
                    break;

                case validval.TransFrom:
                    keyvaltbl.Add("SO", "Salesorder");
                    keyvaltbl.Add("SA", "Sales");
                    break;

                case validval.IsStockAdjustment:
                    keyvaltbl.Add("No", "No");
                    keyvaltbl.Add("Yes", "Yes");
                    break;
                case validval.GRGI:
                    keyvaltbl.Add("1", "Goods Receipt");
                    keyvaltbl.Add("2", "Goods Issue");
                    break;
            }
            return keyvaltbl;

        }

        private void AddFields(string strTab, string strCol, string strDesc, SAPbobsCOM.BoFieldTypes nType, int nEditSize = 10,
        SAPbobsCOM.BoFldSubTypes nSubType = 0, SAPbobsCOM.BoYesNoEnum Mandatory = SAPbobsCOM.BoYesNoEnum.tNO, string defaultvalue = "",
        Dictionary<string, string> keyVal = null, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum linkob = SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone,
        string setlinktable = null)
        {

            SAPbobsCOM.UserFieldsMD oUserFieldMD1;
            oUserFieldMD1 = (SAPbobsCOM.UserFieldsMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields);
            try
            {

                if (!IsColumnExists(strTab, strCol))
                {
                    oUserFieldMD1.Description = strDesc;
                    oUserFieldMD1.Name = strCol;
                    oUserFieldMD1.Type = nType;
                    oUserFieldMD1.SubType = nSubType;
                    oUserFieldMD1.TableName = strTab;
                    oUserFieldMD1.EditSize = nEditSize;
                    oUserFieldMD1.Mandatory = Mandatory;
                    oUserFieldMD1.DefaultValue = defaultvalue;

                    foreach (var item in keyvaltbl)
                    {
                        oUserFieldMD1.ValidValues.Value = item.Key;
                        oUserFieldMD1.ValidValues.Description = item.Value;
                        oUserFieldMD1.ValidValues.Add();
                    }

                    if (setlinktable != null)
                    {
                        oUserFieldMD1.LinkedTable = setlinktable;
                    }
                    else if (linkob != SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone)
                    {
                        oUserFieldMD1.LinkedSystemObject = linkob;
                    }
                    int val;
                    val = oUserFieldMD1.Add();

                    if (val != 0)
                    {
                        clsModule.objaddon.objapplication.SetStatusBarMessage(clsModule.objaddon.objcompany.GetLastErrorDescription() + " " + strTab + " " + strCol, SAPbouiCOM.BoMessageTime.bmt_Short, true);
                    }
                    // System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldMD1)
                }
                keyvaltbl.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldMD1);
                oUserFieldMD1 = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        private bool IsColumnExists(string Table, string Column)
        {
            SAPbobsCOM.Recordset oRecordSet = null;
            string strSQL;
            try
            {
                if (clsModule.objaddon.HANA)
                {
                    strSQL = "SELECT COUNT(*) FROM CUFD WHERE \"TableID\" = '" + Table + "' AND \"AliasID\" = '" + Column + "'";
                }
                else
                {
                    strSQL = "SELECT COUNT(*) FROM CUFD WHERE TableID = '" + Table + "' AND AliasID = '" + Column + "'";
                }

                oRecordSet = (SAPbobsCOM.Recordset)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                oRecordSet.DoQuery(strSQL);

                if (Convert.ToInt32(oRecordSet.Fields.Item(0).Value) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecordSet);
                oRecordSet = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        private void AddKey(string strTab, string strColumn, string strKey, int i)
        {
            var oUserKeysMD = default(SAPbobsCOM.UserKeysMD);

            try
            {
                // // The meta-data object must be initialized with a
                // // regular UserKeys object
                oUserKeysMD = (SAPbobsCOM.UserKeysMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserKeys);

                if (!oUserKeysMD.GetByKey("@" + strTab, i))
                {

                    // // Set the table name and the key name
                    oUserKeysMD.TableName = strTab;
                    oUserKeysMD.KeyName = strKey;

                    // // Set the column's alias
                    oUserKeysMD.Elements.ColumnAlias = strColumn;
                    oUserKeysMD.Elements.Add();
                    oUserKeysMD.Elements.ColumnAlias = "RentFac";

                    // // Determine whether the key is unique or not
                    oUserKeysMD.Unique = SAPbobsCOM.BoYesNoEnum.tYES;

                    // // Add the key
                    if (oUserKeysMD.Add() != 0)
                    {
                        throw new Exception(clsModule.objaddon.objcompany.GetLastErrorDescription());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserKeysMD);
                oUserKeysMD = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void AddUDO(string strUDO, string strUDODesc, SAPbobsCOM.BoUDOObjType nObjectType, string strTable, string[] childTable, string[] sFind, bool canlog = false, bool Manageseries = false)
        {

            SAPbobsCOM.UserObjectsMD oUserObjectMD = null;
            int tablecount = 0;
            try
            {
                oUserObjectMD = (SAPbobsCOM.UserObjectsMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD);

                if (!oUserObjectMD.GetByKey(strUDO)) //(oUserObjectMD.GetByKey(strUDO) == 0)
                {
                    oUserObjectMD.Code = strUDO;
                    oUserObjectMD.Name = strUDODesc;
                    oUserObjectMD.ObjectType = nObjectType;
                    oUserObjectMD.TableName = strTable;                    
                    

                    oUserObjectMD.CanCancel = SAPbobsCOM.BoYesNoEnum.tYES;
                    oUserObjectMD.CanClose = SAPbobsCOM.BoYesNoEnum.tYES;
                    oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tYES;
                    oUserObjectMD.CanDelete = SAPbobsCOM.BoYesNoEnum.tYES;

                    if (Manageseries)
                        oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tYES;
                    else
                        oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tNO;

                    if (canlog)
                    {
                        oUserObjectMD.CanLog = SAPbobsCOM.BoYesNoEnum.tYES;
                        oUserObjectMD.LogTableName = "A" + strTable.ToString();
                    }
                    else
                    {
                        oUserObjectMD.CanLog = SAPbobsCOM.BoYesNoEnum.tNO;
                        oUserObjectMD.LogTableName = "";
                    }

                    oUserObjectMD.CanYearTransfer = SAPbobsCOM.BoYesNoEnum.tNO;
                    

                    oUserObjectMD.CanFind = SAPbobsCOM.BoYesNoEnum.tYES;
                    tablecount = 1;
                    if (sFind.Length > 0)
                    {
                        for (int i = 0, loopTo = sFind.Length - 1; i <= loopTo; i++)
                        {
                            if (string.IsNullOrEmpty(sFind[i]))
                                continue;
                            oUserObjectMD.FindColumns.ColumnAlias = sFind[i];
                            oUserObjectMD.FindColumns.Add();
                            oUserObjectMD.FindColumns.SetCurrentLine(tablecount);
                            
                            oUserObjectMD.FormColumns.FormColumnDescription = sFind[i].Replace("U_","");
                            if (sFind[i].StartsWith("U_"))
                                oUserObjectMD.FormColumns.Editable = SAPbobsCOM.BoYesNoEnum.tYES;
                            oUserObjectMD.FormColumns.FormColumnAlias = sFind[i];
                            oUserObjectMD.FormColumns.Add();
                            oUserObjectMD.FormColumns.SetCurrentLine(tablecount);

                            tablecount = tablecount + 1;
                        }
                    }

                    tablecount = 0;
                    if (childTable != null)
                    {
                        if (childTable.Length > 0)
                        {
                            for (int i = 0, loopTo1 = childTable.Length - 1; i <= loopTo1; i++)
                            {
                                if (string.IsNullOrEmpty(childTable[i]))
                                    continue;
                                oUserObjectMD.ChildTables.SetCurrentLine(tablecount);
                                oUserObjectMD.ChildTables.TableName = childTable[i];
                                oUserObjectMD.ChildTables.Add();
                                tablecount = tablecount + 1;
                            }
                        }
                    }
                   
                    

                    if (oUserObjectMD.Add() != 0)
                    {
                        throw new Exception(clsModule.objaddon.objcompany.GetLastErrorDescription());
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserObjectMD);
                oUserObjectMD = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

        }


        #endregion

    }
}
