<template>
  <div class="hello">
    <Navbar />
    <div id="content">
      <h3>Add details</h3>
      <input name="firstName" v-model="Name" placeholder="Name" />
      <br />
      <input name="lastName" v-model="LastName" placeholder="Last name" />
      <br />
      <input name="username" v-model="UserName" placeholder="Username" />
      <br />
      <input name="address" v-model="Address" placeholder="Address" />
      <br />
      <input name="hometown" v-model="Hometown" placeholder="Hometown" />
      <br />
      <input name="zipcode" v-model="ZipCode" placeholder="Zipcode" />
      <br />
      <input name="country" v-model="Country" placeholder="Country" />
      <br />
      <input name="mail" v-model="Mail" placeholder="Mail" />
      <br />
      <input name="telephone" v-model="Telephone" placeholder="Telephone" />
      <br />
      <button v-on:click="sendToServer">Submit</button>
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
          Telephone: this.Telephone
        },
      })
        .then(function (response) {
          console.log(response);
        })
        .catch(function (error) {
          console.log(error);
        });
    },
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../../assets/style/warehouse_style.css">
</style>


