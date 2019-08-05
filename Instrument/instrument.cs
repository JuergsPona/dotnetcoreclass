namespace FutureGrowth.Instruments {

    public class Instrument {

        public string InstrCode { get; set; }
        public string InstrDesc { get; set; }
        public string IssuerCode { get; set; }
        public double MarketValue { get; set; }
        public double ModDur { get; set; }

        public Instruments (string instrCode, string instrDesc, string issuerCode, double marketValue, double modDur) {

            InstrCode = instrCode;
            InstrDesc = instrDesc;
            IssuerCode = issuerCode;
            MarketValue = marketValue;
            ModDur = modDur;

        }

        //get instruments from db
        public List<Instrument> GetInstrumentsFromDatabase (string instrCode) {

            List<Instrument> listOfInstruments = new List<Instrument> ();
            /*
             * Code here to query database
             *
             */

            return listOfInstruments;
        }

        //add instrument details
        public void AddInstrument (List<Instrument> newInstrumentDetails) {
            for (int i = 0 : i < existingInstrumentDetails.Count - 1; i++) {
                // Code here to send ot database.
            }
        }

        //update instrument details
        public void UpdateInstrument (List<Instrument> existingInstrumentDetails) {
            for (int i = 0 : i < existingInstrumentDetails.Count - 1; i++) {
                // Code here to send ot database.
            }
        }

    }

}