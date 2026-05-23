using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Restaurant_IHEC
{
    public static class EmailService
    {
        public static  void EnvoyerEmailAuthentification()
        {
            try
            {
                // Configuration SMTP
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);//l'objet qui gère l'envoi
                client.UseDefaultCredentials = false;//N'utilise pas mon compte Windows
                client.Credentials = new NetworkCredential("emnasaidi54@gmail.com", "vpia rwbv fjjt pogc");
                client.EnableSsl = true;//Active le cryptage du mail

                //Création du mail
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("emnasaidi54@gmail.com");//adminstration mail
                mail.To.Add(Session.email);
                mail.Subject = "Votre code d'authauthentification";
                mail.Body =
                "Bonjour,\n\n" +
                            "Votre code de vérification est : " + Session.codeVerification + "\n\n" +
                            "Veuillez saisir ce code pour confirmer votre identité.\n\n" +
                            "Si vous n’êtes pas à l’origine de cette demande, ignorez cet e-mail.\n\n" +
                            "Cordialement,\n" +
                            "L’équipe Restaurant IHEC Carthage";
                //Envoi
                client.Send(mail);
                MessageBox.Show("E-mail envoyé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoie du mail : " + ex.Message);
            }

        }
        public static void EnvoyerCodeReservation(string code,DateTime date,string menu)
        {
            try
            {
                // Configuration SMTP
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);//l'objet qui gère l'envoi
                client.UseDefaultCredentials = false;//N'utilise pas mon compte Windows
                client.Credentials = new NetworkCredential("emnasaidi54@gmail.com", "vpia rwbv fjjt pogc");
                client.EnableSsl = true;//Active le cryptage du mail

                //Création du mail
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("emnasaidi54@gmail.com");//adminstration mail
                mail.To.Add(Session.email);
                mail.Subject = "Votre code Reservation";
                mail.Body =
                "Bonjour,\n\n" +
            "Votre réservation a été enregistrée avec succès.\n\n" +
            "Détails de la réservation :\n" +
            "- Code de réservation : " + code + "\n" +
            "- Date prévue : " + date + "\n" + // Ajout de la date
            "- Menu choisi : " + menu + "\n\n" + // Ajout du menu
            "Veuillez présenter ce code à l'entrée du restaurant pour récupérer votre repas.\n\n" +
            "Si vous souhaitez annuler votre réservation, merci de le faire le plus tôt possible.\n\n" +
            "Cordialement,\n" +
            "L'équipe du Restaurant IHEC Carthage";
                //Envoi
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoie du mail : " + ex.Message);
            }

        }
    }
}