<template>
  <div class="hello">
    <Navbar />
    <div id="content">
      <h3 id="titleCreateUser">Add details</h3>

      <div class="form-group" :class="{ 'form-group--error': $v.name.$error }">
        <label class="form__label">Name</label>
        <input class="form__input" v-model.trim="$v.name.$model" />
      </div>
      <div class="error" v-if="!$v.name.required">Field is required</div>
      <div class="error" v-if="!$v.name.minLength">
        Name must have at least {{ $v.name.$params.minLength.min }} letters.
      </div>
      <tree-view
        :data="$v.name"
        :options="{ rootObjectKey: '$v.name', maxDepth: 2 }"
      ></tree-view>
      <div class="form-group" :class="{ 'form-group--error': $v.age.$error }">
        <label class="form__label">Age</label>
        <input class="form__input" v-model.trim.lazy="$v.age.$model" />
      </div>
      <div class="error" v-if="!$v.age.between">
        Must be between {{ $v.age.$params.between.min }} and
        {{ $v.age.$params.between.max }}
      </div>
      <tree-view
        :data="$v.age"
        :options="{ rootObjectKey: '$v.age', maxDepth: 2 }"
      ></tree-view>

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
import { required, minLength, between } from "vuelidate/lib/validators";

export default {
  components: {
    Navbar,
  },
  data() {
    return {
      myToggle: false,
      name: "",
      age: 0,
      Name: "",
      LastName: "",
      UserName: "",
      Address: "",
      Hometown: "",
      ZipCode: "",
      Country: "",
      Mail: "",
      Telephone: "",
    };
  },
  computed: {
    btnStates() {
      return this.buttons.map((btn) => btn.state);
    },
  },
  validations: {
    name: {
      required,
      minLength: minLength(4),
    },
    age: {
      between: between(20, 30),
    },
  },
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


