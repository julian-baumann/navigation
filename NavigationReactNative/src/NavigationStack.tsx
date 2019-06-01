import React from 'react';
import { requireNativeComponent } from 'react-native';
import { StateNavigator } from 'navigation';
import { NavigationContext } from 'navigation-react';
import Scene from './Scene';

class NavigationStack extends React.Component<{stateNavigator: StateNavigator}> {
    constructor(props) {
        super(props);
        this.onNavigateBackIOS = this.onNavigateBackIOS.bind(this);
    }
    onNavigateBackIOS({nativeEvent: {crumb}}) {
        var {stateNavigator} = this.props;
        var distance = stateNavigator.stateContext.crumbs.length - crumb;
        if (stateNavigator.canNavigateBack(distance))
            stateNavigator.navigateBack(distance);
    }
    getScenes(){
        var {stateNavigator} = this.props;
        var {crumbs, nextCrumb} = stateNavigator.stateContext;
        return crumbs.concat(nextCrumb).map(({state, data, url}, index, crumbsAndNext) => {
            var preCrumbs = crumbsAndNext.slice(0, index);
            var {state: nextState, data: nextData} = crumbsAndNext[index + 1] || {state: undefined, data: undefined};
            return {key: index, state, data, url, crumbs: preCrumbs, nextState, nextData, mount: url === nextCrumb.url};
        });
    }
    render() {
        return (
            <NVNavigationStack onNavigateBackIOS={this.onNavigateBackIOS}>
                {this.getScenes().map(({key}) => <Scene key={key} crumb={key} />)}
            </NVNavigationStack>
        );
    }
};

var  NVNavigationStack = requireNativeComponent<any>('NVNavigationStack', null);

export default props => (
    <NavigationContext.Consumer>
        {(navigationEvent) => <NavigationStack stateNavigator={navigationEvent.stateNavigator} {...props} />}
    </NavigationContext.Consumer>
)
