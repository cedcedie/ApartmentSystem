using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;

namespace ApartmentSystem
{
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
                string outputPath = @"C:\pdf\agreement.pdf";
                Document document = new Document();

                try
                {

                    PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));
                    document.Open();
                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);


                    Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);


                    AddCenteredText(document, "CONTRACT OF LEASE", boldFont);
                    AddText(document, "\n\nKNOWN ALL MEN BY THESE PRESENTS:", boldFont);
                    AddText(document, "\nThis CONTRACT OF LEASE made and executed by and between:", normalFont);
                    AddText(document, "\nLANDLORD/LESSOR:", boldFont);
                    AddText(document, " ___________________, of legal age, (Civil Status)_____________, Filipino national and a resident of (Complete Address) ________________________, Philippines,", normalFont);
                    AddText(document, "-and-\n", normalFont);
                    AddText(document, "LESSEE/TENANT:", boldFont);
                    AddText(document, " _____________________, of legal age, (Civil Status)________, Filipino national and a resident of (Complete Address)__________________,", normalFont);
                    AddText(document, "hereinafter referred to as the LANDLORD/LESSOR and LESSEE/TENANT respectively.", normalFont);

                    AddCenteredText(document, "\nWITNESSETH:", boldFont);
                    AddText(document, "The LESSOR is the owner of a residential house situated at _____________________.", normalFont);
                    AddText(document, "The LESSOR hereby leases unto the LESSEE the above-mentioned residential building, and the latter agrees to lease the same under the following terms and conditions:", normalFont);

                    AddText(document, "\n1. That the term of this lease shall be for a period of (__) months and will start on __________ upon signing of this contract and renewable for another period;", normalFont);
                    AddText(document, "\n2. That the monthly rental of the lease shall be ____________________ PESOS (P________.00), per month; payable in every __ of the month. It does not include the monthly homeowner’s dues; Upon signing this contract, the LESSEE shall pay an advance rental equivalent to one (1) month deposit and one (1) month advance deposit;", normalFont);
                    AddText(document, "\n3. If any monthly payment is late, a grace period of 3 days will be granted. On the fourth day after rent is due, a penalty of one thousand pesos per day will be due in addition to the rent owed to date;", normalFont);
                    AddText(document, "\n4. The LESSEE agrees that the security deposit cannot be used in lieu of monthly rental payments", normalFont);
                    AddText(document, "\n5. The LESSOR agrees to fully refund the security deposit of the LESSEE upon successful inspection of the premises when returning the house to the LESSOR. Any damages or missing items can be subtracted from the security deposit. The LESSEE agrees to replace or refund at replacement value any household item that is missing, damaged or broken;", normalFont);
                    AddText(document, "\n6. The LESSEE expressly agrees and warrants that the leased premises shall be exclusively utilised for residential purposes only;", normalFont);
                    AddText(document, "\n7. The LESSEE shall keep the leased premised in good and habitable condition and any damages caused by the LESSEE in the said premises shall be to his account;", normalFont);
                    AddText(document, "\n8. The LESSEE shall pay promptly the electrical, water and internet bills used in the leased premises so that the same could not be disrupted for this purpose; the LESSOR is hereby authorised by the LESSEE to inspect the corresponding billing of the above-mentioned services;", normalFont);
                    AddText(document, "\n9. The LESSEE shall permit the LESSOR to enter and view the leased premises at the reasonable hours and with reasonable notice given;", normalFont);
                    AddText(document, "\n10. The LESSEE shall not bring into or store in the leased premises anything of highly inflammable nature or explosive material that may expose the leased premises to fire;", normalFont);
                    AddText(document, "\n11. It is understood that the LESSOR has the option to automatically rescind this contract if the LESSEE failed to pay the rental in 1 month;", normalFont);
                    AddText(document, "\n12. In the event the LESSEE pre-termination of this agreement for and reason; whatsoever, the LESSOR shall automatically forfeited the advance rental and deposit he/she made as liquidated damages.", normalFont);
                    AddText(document, "\n13. That the LESSEE is expressly prohibited to sub-lease the lease premises to anybody, without the express consent of the LESSOR in writing;", normalFont);
                    AddText(document, "\n14. That the LESSEE shall be responsible for the observance of sanitary and electrical regulations required of impose by the City of Government of authorities;", normalFont);
                    AddText(document, "\n15. The improvements introduce by the LESSE shall be for his/her own account.", normalFont);
                    AddText(document, "\n16. The LESSEE will be responsible returning fully functioning and recently cleaned air conditioning unit to the LESSOR; (the lessor will provide the receipt for the air conditioning cleaning upon house turn over, the lessee will also provide the proof of recent cleaning to the lessor upon return of the house at the end of the lease.)", normalFont);
                    AddText(document, "\n17. The LESSEE assumed responsibility for any repair of the air conditioning during the lease period.", normalFont);
                    AddText(document, "\n18. All actions that may arise from this contract shall be instituted in the proper courts of_______ only.", normalFont);

                    AddText(document, "\n\n\nIN WITNESS WHEREOF, we have hereunto set our hands on this ______________ in the City/Province of __________, Philippines.", boldFont);
                    AddText(document, "\n\n(Signed) LESSOR'S FULL NAME", normalFont);
                    AddText(document, "\n\n(Signed) LESSOR'S FULL NAME", normalFont);
                    AddText(document, "\n\nSIGNED IN THE PRESENCE OF:", normalFont);
                    AddText(document, "\n\n(Witness' complete name and signature)", normalFont);
                    AddText(document, "\n\n(Witness' complete name and signature)", normalFont);

                    AddCenteredText(document, "\n\nA C K N O W L E D G M E N T", boldFont);
                    AddText(document, "\nREPUBLIC OF THE PHILIPPINES)\nCITY OF ______________________) S.S.\n", normalFont);
                    AddText(document, "x---------------------------------------x\n\n", normalFont);
                    AddText(document, "BEFORE ME, a Notary Public for the City and Province of ________, on this day __________, personally appeared the above mentioned persons identified with their competent evidence of identity written below their respective names known to me to be the same persons who executed the foregoing instrument and they acknowledged to me that the same is their own free and voluntary act and deed. This instrument consists of three (3) pages including the acknowledgement, which have been signed on each and every page by the parties and their instrumental witnesses including the page on which this acknowledgment is written.\n\nWITNESS MY HAND AND SEAL.\nDoc. No. _______;\nPage No. _______; NOTARY PUBLIC Book No._______;\nSeries of 202__.", normalFont);




                }
                catch (DocumentException de)
                {
                    MessageBox.Show("Error creating PDF: " + de.Message);
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error creating PDF: " + ioe.Message);
                }
                finally
                {
                    if (document != null && document.IsOpen())
                        document.Close();
                }
            }

            static void AddCenteredText(Document document, string text, Font font)
            {

                Paragraph paragraph = new Paragraph(text, font);
                paragraph.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph);
            }

            static void AddText(Document document, string text, Font font)
            {
                Paragraph paragraph = new Paragraph(text, font);

                document.Add(paragraph);
            }
        }
    }

