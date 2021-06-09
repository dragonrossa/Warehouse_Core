<template>
  <div class="hello">
    <Navbar />
    <div id="content">
      <h3 id="titleCreateUser">Add details</h3>
      <div id="formInputs">
        <span>First name:</span>
        <b-form-input
          name="firstName"
          v-model="Name"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Last name:</span>
        <b-form-input
          name="lastName"
          v-model="LastName"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Username:</span>
        <b-form-input
          name="username"
          v-model="UserName"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Address:</span>
        <b-form-input
          name="address"
          v-model="Address"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Hometown:</span>
        <b-form-input
          name="hometown"
          v-model="Hometown"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Zip code:</span>
        <b-form-input
          name="zipcode"
          v-model="ZipCode"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Country:</span>
        <b-form-input
          name="country"
          v-model="Country"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Mail:</span>
        <b-form-input
          name="mail"
          v-model="Mail"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>
      <div id="formInputs">
        <span>Telephone:</span>
        <b-form-input
          name="telephone"
          v-model="Telephone"
          class="inputType"
          type="text"
          debounce="500"
        ></b-form-input>
        <br />
      </div>

      <div id="submitCreateUser">
        <b-button
          :pressed.sync="myToggle"
          variant="primary"
          v-on:click="sendToServer"
          >Submit</b-button
        >
      </div>
    </div>
    <router-view></router-view>
  </div>
</template>

<script>
import Navbar from "./../Navbar";
import axios from "axios";

export default {
  components: {
    Navbar,
  },
  data() {
    return {
      myToggle: false,
    };
  },
  computed: {
    btnStates() {
      return this.buttons.map((btn) => btn.state);
    },
  },
  Name: "",
  LastName: "",
  UserName: "",
  Address: "",
  Hometown: "",
  ZipCode: "",
  Country: "",
  Mail: "",
  Telephone: "",
  methods: {
    sendToServer: function () {
      if (this.myToggle == true) {
        axios({
          method: "post",
          url: "/user/create",
          data: {
            Name: this.Name,
            LastName: this.LastName,
            UserName: this.UserName,
            Address: this.Address,
            Hometown: this.Hometown,
            ZipCode: this.ZipCode,
            Country: this.Country,
            Mail: this.Mail,
            Telephone: this.Telephone,
          },
        })
          .then(function (response) {
            console.log(response);
          })
          .catch(function (error) {
            console.log(error);
          });
      }
    },
  },
};
</script>

<style scoped src="../../assets/style/warehouse_style.css">
</style>


