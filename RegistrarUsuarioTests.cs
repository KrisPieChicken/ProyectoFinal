using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;
using System;
using System.Windows.Forms;

namespace ProyectoFinal.Tests
{
    [TestClass]
    public class RegistrarUsuarioTests
    {
        [TestMethod]
        public void TestGuardarNuevoUsuarioCamposVacios()
        {
            // Arrange
            var form = new Registrar_Usuario();
            form.txt_rutRegistro.Text = "";
            form.txt_NomApRegistro.Text = "";
            form.txt_ConstrasenaRegistro.Text = "";
            form.txt_CorreoRegistro.Text = "";
            form.cmBox_CargoRegistro.Text = "Seleccione un cargo";

            // Act
            var result = Record.Exception(() => form.btn_Guardar_Nuevo_Click(null, null));

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Exception));
            Assert.AreEqual("Los campos obligatorios no deben estar vacíos", result.Message);
        }

        [TestMethod]
        public void TestGuardarNuevoUsuarioCargoNoSeleccionado()
        {
            // Arrange
            var form = new Registrar_Usuario();
            form.txt_rutRegistro.Text = "12345678";
            form.txt_NomApRegistro.Text = "Test User";
            form.txt_ConstrasenaRegistro.Text = "password";
            form.txt_CorreoRegistro.Text = "test@example.com";
            form.cmBox_CargoRegistro.Text = "Seleccione un cargo";

            // Act
            var result = Record.Exception(() => form.btn_Guardar_Nuevo_Click(null, null));

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Exception));
            Assert.AreEqual("Debe seleccionar un cargo", result.Message);
        }
    }
}
