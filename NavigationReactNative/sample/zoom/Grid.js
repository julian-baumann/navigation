import React from 'react';
import {StyleSheet, ScrollView, Text, View, TouchableHighlight} from 'react-native';
import {NavigationContext} from 'navigation-react';
import {SharedElementAndroid} from 'navigation-react-native';

const colors = [
  'maroon', 'red', 'crimson', 'orange', 'brown', 'sienna', 'olive',
  'purple', 'fuchsia', 'indigo', 'green', 'navy', 'blue', 'teal', 'black'
];

export default () => (
  <NavigationContext.Consumer>
    {({stateNavigator}) => (
      <ScrollView contentInsetAdjustmentBehavior="automatic">
        <View style={styles.colors}>
          {colors.map(color => (
            <SharedElementAndroid
              key={color}
              name={color}
              style={styles.shared}>
              <TouchableHighlight
                style={[
                  {backgroundColor: color},
                  styles.color
                ]}
                underlayColor={color}                
                onPress={() => {
                  stateNavigator.navigate('detail', {
                    color, sharedElements: [color]
                  });
                }}>
                <Text style={styles.text}>{color}</Text>
              </TouchableHighlight>
            </SharedElementAndroid>
          ))}
        </View>
      </ScrollView>
    )}
  </NavigationContext.Consumer>
);

const styles = StyleSheet.create({
  colors: {
    flexDirection: 'row',
    flexWrap: 'wrap',
    justifyContent: 'center',
    marginTop: 10,
  },
  shared: {
    marginLeft:10,
    marginRight: 10,
    marginBottom: 20,
  },
  color: {
    width: 100,
    height: 150,
    justifyContent: 'center',
  },
  text: {
    color: '#fff',
    fontSize: 20,
    textAlign: 'center',
    fontWeight: 'bold',
  }
});